// Injects server/client active checks for [Server/Client] attributes
using Mono.CecilX;
using Mono.CecilX.Cil;

namespace Mirror.Weaver
{
    static class ServerClientAttributeProcessor
    {
        public static bool Process(WeaverTypes weaverTypes, TypeDefinition td)
        {
            bool modified = false;
            foreach (MethodDefinition md in td.Methods)
            {
                modified |= ProcessSiteMethod(weaverTypes, md);
            }

            foreach (TypeDefinition nested in td.NestedTypes)
            {
                modified |= Process(weaverTypes, nested);
            }
            return modified;
        }

        static bool ProcessSiteMethod(WeaverTypes weaverTypes, MethodDefinition md)
        {
            if (md.Name == ".cctor" ||
                md.Name == NetworkBehaviourProcessor.ProcessedFunctionName ||
                md.Name.StartsWith(Weaver.InvokeRpcPrefix))
                return false;

            if (md.IsAbstract)
            {
                if (HasServerClientAttribute(md))
                {
                    Weaver.Error("Server or Client Attributes can't be added to abstract method. Server and Client Attributes are not inherited so they need to be applied to the override methods instead.", md);
                    Weaver.WeavingFailed = true;
                }
                return false;
            }

            if (md.Body != null && md.Body.Instructions != null)
            {
                return ProcessMethodAttributes(weaverTypes, md);
            }
            return false;
        }

        public static bool HasServerClientAttribute(MethodDefinition md)
        {
            foreach (CustomAttribute attr in md.CustomAttributes)
            {
                switch (attr.Constructor.DeclaringType.ToString())
                {
                    case "Mirror.ServerAttribute":
                    case "Mirror.ServerCallbackAttribute":
                    case "Mirror.ClientAttribute":
                    case "Mirror.ClientCallbackAttribute":
                        return true;
                    default:
                        break;
                }
            }
            return false;
        }

        public static bool ProcessMethodAttributes(WeaverTypes weaverTypes, MethodDefinition md)
        {
            if (md.HasCustomAttribute<ServerAttribute>())
                InjectServerGuard(weaverTypes, md, true);
            else if (md.HasCustomAttribute<ServerCallbackAttribute>())
                InjectServerGuard(weaverTypes, md, false);
            else if (md.HasCustomAttribute<ClientAttribute>())
                InjectClientGuard(weaverTypes, md, true);
            else if (md.HasCustomAttribute<ClientCallbackAttribute>())
                InjectClientGuard(weaverTypes, md, false);
            else
                return false;

            return true;
        }

        static void InjectServerGuard(WeaverTypes weaverTypes, MethodDefinition md, bool logWarning)
        {
            ILProcessor worker = md.Body.GetILProcessor();
            Instruction top = md.Body.Instructions[0];

            worker.InsertBefore(top, worker.Create(OpCodes.Call, weaverTypes.NetworkServerGetActive));
            worker.InsertBefore(top, worker.Create(OpCodes.Brtrue, top));
            if (logWarning)
            {
                worker.InsertBefore(top, worker.Create(OpCodes.Ldstr, $"[Server] function '{md.FullName}' called when server was not active"));
                worker.InsertBefore(top, worker.Create(OpCodes.Call, weaverTypes.logWarningReference));
            }
            InjectGuardParameters(md, worker, top);
            InjectGuardReturnValue(md, worker, top);
            worker.InsertBefore(top, worker.Create(OpCodes.Ret));
        }

        static void InjectClientGuard(WeaverTypes weaverTypes, MethodDefinition md, bool logWarning)
        {
            ILProcessor worker = md.Body.GetILProcessor();
            Instruction top = md.Body.Instructions[0];

            worker.InsertBefore(top, worker.Create(OpCodes.Call, weaverTypes.NetworkClientGetActive));
            worker.InsertBefore(top, worker.Create(OpCodes.Brtrue, top));
            if (logWarning)
            {
                worker.InsertBefore(top, worker.Create(OpCodes.Ldstr, $"[Client] function '{md.FullName}' called when client was not active"));
                worker.InsertBefore(top, worker.Create(OpCodes.Call, weaverTypes.logWarningReference));
            }

            InjectGuardParameters(md, worker, top);
            InjectGuardReturnValue(md, worker, top);
            worker.InsertBefore(top, worker.Create(OpCodes.Ret));
        }

        // this is required to early-out from a function with "ref" or "out" parameters
        static void InjectGuardParameters(MethodDefinition md, ILProcessor worker, Instruction top)
        {
            int offset = md.Resolve().IsStatic ? 0 : 1;
            for (int index = 0; index < md.Parameters.Count; index++)
            {
                ParameterDefinition param = md.Parameters[index];
                if (param.IsOut)
                {
                    TypeReference elementType = param.ParameterType.GetElementType();

                    md.Body.Variables.Add(new VariableDefinition(elementType));
                    md.Body.InitLocals = true;

                    worker.InsertBefore(top, worker.Create(OpCodes.Ldarg, index + offset));
                    worker.InsertBefore(top, worker.Create(OpCodes.Ldloca_S, (byte)(md.Body.Variables.Count - 1)));
                    worker.InsertBefore(top, worker.Create(OpCodes.Initobj, elementType));
                    worker.InsertBefore(top, worker.Create(OpCodes.Ldloc, md.Body.Variables.Count - 1));
                    worker.InsertBefore(top, worker.Create(OpCodes.Stobj, elementType));
                }
            }
        }

        // this is required to early-out from a function with a return value.
        static void InjectGuardReturnValue(MethodDefinition md, ILProcessor worker, Instruction top)
        {
            if (!md.ReturnType.Is(typeof(void)))
            {
                md.Body.Variables.Add(new VariableDefinition(md.ReturnType));
                md.Body.InitLocals = true;

                worker.InsertBefore(top, worker.Create(OpCodes.Ldloca_S, (byte)(md.Body.Variables.Count - 1)));
                worker.InsertBefore(top, worker.Create(OpCodes.Initobj, md.ReturnType));
                worker.InsertBefore(top, worker.Create(OpCodes.Ldloc, md.Body.Variables.Count - 1));
            }
        }
    }
}