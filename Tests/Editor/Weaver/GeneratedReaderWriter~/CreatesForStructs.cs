using Mirror;
using Mirror.Weaver.Tests.Extra;

namespace GeneratedReaderWriter.CreatesForStructs
{
    public class CreatesForStructs : NetworkBehaviour
    {
        [ClientRpc]
        public void RpcDoSomething(SomeOtherData data)
        {
            // empty
        }
    }

    public struct SomeOtherData
    {
        public int usefulNumber;
    }
}
