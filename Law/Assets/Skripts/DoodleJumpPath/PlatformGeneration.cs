using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject[] platformPrefab;
    private int Num;
   

    private void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 10; i++)
        {
            Num = Random.Range(0,5);
            SpawnerPosition.x = Random.Range(-7f,7f);
            SpawnerPosition.y += Random.Range(1f, 3f);


            Instantiate(platformPrefab[Num], SpawnerPosition, Quaternion.identity);
        }
    }
}
