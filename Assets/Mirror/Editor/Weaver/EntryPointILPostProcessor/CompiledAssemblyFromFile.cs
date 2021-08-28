// tests use WeaveAssembler, which uses AssemblyBuilder to Build().
// afterwards ILPostProcessor weaves the build.
// this works on windows, but build() does not run ILPP on mac atm.
// we need to manually invoke ILPP with an assembly from file.
using System.IO;
using Unity.CompilationPipeline.Common.ILPostProcessing;

namespace Mirror.Weaver
{
    public class CompiledAssemblyFromFile : ICompiledAssembly
    {
        readonly string assemblyPath;
        InMemoryAssembly inMemoryAssembly;

        public string Name => Path.GetFileNameWithoutExtension(assemblyPath);
        public string[] References { get; set; }
        public string[] Defines { get; set; }

        public CompiledAssemblyFromFile(string assemblyPath)
        {
            this.assemblyPath = assemblyPath;
        }

        public InMemoryAssembly InMemoryAssembly
        {
            get
            {
                if (inMemoryAssembly == null)
                {
                    byte[] peData = File.ReadAllBytes(assemblyPath);
                    string pdbFileName = Path.GetFileNameWithoutExtension(assemblyPath) + ".pdb";
                    byte[] pdbData = File.ReadAllBytes(Path.Combine(Path.GetDirectoryName(assemblyPath), pdbFileName));
                    inMemoryAssembly = new InMemoryAssembly(peData, pdbData);
                }
                return inMemoryAssembly;
            }
        }
    }
}
