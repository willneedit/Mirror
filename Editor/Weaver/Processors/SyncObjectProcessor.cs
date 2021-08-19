using System.Collections.Generic;
using Mono.CecilX;

namespace Mirror.Weaver
{
    public static class SyncObjectProcessor
    {
        // Finds SyncObjects fields in a type
        // Type should be a NetworkBehaviour
        public static List<FieldDefinition> FindSyncObjectsFields(TypeDefinition td)
        {
            List<FieldDefinition> syncObjects = new List<FieldDefinition>();

            foreach (FieldDefinition fd in td.Fields)
            {
                if (fd.FieldType.Resolve().ImplementsInterface<SyncObject>())
                {
                    if (fd.IsStatic)
                    {
                        Weaver.Error($"{fd.Name} cannot be static", fd);
                        Weaver.WeavingFailed = true;
                        continue;
                    }

                    GenerateReadersAndWriters(fd.FieldType);

                    syncObjects.Add(fd);
                }
            }


            return syncObjects;
        }

        // Generates serialization methods for synclists
        static void GenerateReadersAndWriters(TypeReference tr)
        {
            if (tr is GenericInstanceType genericInstance)
            {
                foreach (TypeReference argument in genericInstance.GenericArguments)
                {
                    if (!argument.IsGenericParameter)
                    {
                        Readers.GetReadFunc(argument);
                        Writers.GetWriteFunc(argument);
                    }
                }
            }

            if (tr != null)
            {
                GenerateReadersAndWriters(tr.Resolve().BaseType);
            }
        }
    }
}
