using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectibles : MonoBehaviour
{
    [SerializeField] Transform[] collectibles;
    [SerializeField] float count = 5;


    void Spawn()
    {
        Vector3 randomizeFeederPosition = new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(-0.1f, 190f));
        Vector3 randomizePacifierPosition = new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(-0.1f, 190f));

        for (int i = 0; i < count; i++)
        {
            Instantiate(collectibles[0], randomizeFeederPosition, Quaternion.identity, transform);
            randomizeFeederPosition.z = randomizeFeederPosition.z + 3;

            Instantiate(collectibles[1], randomizePacifierPosition, Quaternion.identity, transform);
            randomizePacifierPosition.z = randomizePacifierPosition.z + 3;
        }
    }

    private void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
    }
}
