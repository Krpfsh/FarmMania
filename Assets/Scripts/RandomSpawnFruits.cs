using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnFruits : MonoBehaviour
{
    public GameObject[] cubePrefab;
    private void Start()
    {
        InvokeRepeating("Spawn", 0.7f, 0.7f);
    }
    private void Spawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-4f, 4f), 0.5f, Random.Range(-5.45f, 0));
        Instantiate(cubePrefab[Random.Range(0, cubePrefab.Length)], randomSpawnPosition, Quaternion.identity);
    }
}
