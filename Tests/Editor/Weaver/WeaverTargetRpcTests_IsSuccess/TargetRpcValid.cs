using Mirror;

namespace WeaverTargetRpcTests.TargetRpcValid
{
    class TargetRpcValid : NetworkBehaviour
    {
        [TargetRpc]
        void TargetRpcWithNetworkConnection(NetworkConnection nc) { }
    }
}
