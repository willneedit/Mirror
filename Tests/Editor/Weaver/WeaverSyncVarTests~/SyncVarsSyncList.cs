using Mirror;
using System;

namespace WeaverSyncVarTests.SyncVarsSyncList
{

    class SyncVarsSyncList : NetworkBehaviour
    {
        public class SyncObjImplementer : SyncObject
        {
            public Action OnDirty { get; set; }
            public void ClearChanges() { }
            public void OnSerializeAll(NetworkWriter writer) { }
            public void OnSerializeDelta(NetworkWriter writer) { }
            public void OnDeserializeAll(NetworkReader reader) { }
            public void OnDeserializeDelta(NetworkReader reader) { }
            public void Reset() { }
        }

        [SyncVar]
        SyncObjImplementer syncobj;

        [SyncVar]
        SyncList<int> syncints;
    }
}
