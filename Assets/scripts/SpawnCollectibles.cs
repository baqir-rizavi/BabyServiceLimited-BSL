using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectibles : MonoBehaviour
{
    [SerializeField] Transform[] collectibles;
    [SerializeField] float count = 5;
    private int num = 0;


    void Spawn(float zpos)
    {
        Vector3 randomizeFeederPosition = new Vector3(Random.Range(-4.5f, 4.5f), 0, zpos);
        Vector3 randomizePacifierPosition = new Vector3(Random.Range(-4.5f, 4.5f), 0, zpos);
        //int randCollectable = Random.Range(0, collectibles.Length);
        
        for (int i = 0; i < 5; i++)
        {
            if (num % 2 == 0)
            {
                Instantiate(collectibles[0], randomizeFeederPosition, Quaternion.Euler(new Vector3(-120, 0, 0)), transform);
                //Instantiate(collectibles[randCollectable], randomizeFeederPosition, Quaternion.identity, transform);
                randomizeFeederPosition.z = randomizeFeederPosition.z + 3;
            }
            else
            {
                Instantiate(collectibles[1], randomizePacifierPosition, Quaternion.identity, transform);
                randomizePacifierPosition.z = randomizePacifierPosition.z + 3;
            }
        }
    }

    private void Start()
    {
        float lastSpawnPos = 5f;
        for (int i = 0; i < count; i++)
        {
            Spawn(lastSpawnPos);
            lastSpawnPos += Random.Range(20f, 50f);
            num++;
        }
    }
}
