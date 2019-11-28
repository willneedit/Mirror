using UnityEngine;

namespace Mirror.Examples.NetworkRoom
{
    public class Spawner : NetworkBehaviour
    {
        public NetworkIdentity prizePrefab;

        float x;
        float z;

        GameObject newPrize;
        Reward reward;

        public override void OnStartServer()
        {
            for (int i = 0; i < 10; i++)
                SpawnPrize();
        }

        public void SpawnPrize()
        {
            x = Random.Range(-19, 20);
            z = Random.Range(-19, 20);

            newPrize = Instantiate(prizePrefab.gameObject, new Vector3(x, 1, z), Quaternion.identity);
            newPrize.name = prizePrefab.name;
            reward = newPrize.gameObject.GetComponent<Reward>();
            reward.spawner = this;

            NetworkServer.Spawn(newPrize);
        }
    }
}
