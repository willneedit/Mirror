using System;
using System.Collections.Generic;

namespace Mirror
{
    /// <summary>
    /// Allows Middleware to override some of the transport methods or let the inner transport handle them.
    /// </summary>
    public abstract class MiddlewareTransport : Transport
    {
        /// <summary>
        /// Transport to call to after middleware
        /// </summary>
        public Transport inner;

        public override bool Available() => inner.Available();
        public override int GetMaxPacketSize(int channelId = 0) => inner.GetMaxPacketSize(channelId);
        public override void Shutdown() => inner.Shutdown();

        #region Client
        public override void ClientConnect(string address) => inner.ClientConnect(address);
        public override bool ClientConnected() => inner.ClientConnected();
        public override void ClientDisconnect() => inner.ClientDisconnect();
        public override bool ClientSend(int channelId, ArraySegment<byte> segment) => inner.ClientSend(channelId, segment);
        #endregion

        #region Server
        public override bool ServerActive() => inner.ServerActive();
        public override void ServerStart() => inner.ServerStart();
        public override void ServerStop() => inner.ServerStop();
        public override bool ServerSend(List<int> connectionIds, int channelId, ArraySegment<byte> segment) => inner.ServerSend(connectionIds, channelId, segment);
        public override bool ServerDisconnect(int connectionId) => inner.ServerDisconnect(connectionId);
        public override string ServerGetClientAddress(int connectionId) => inner.ServerGetClientAddress(connectionId);
        public override Uri ServerUri() => inner.ServerUri();
        #endregion
    }
}
