using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBonuses : MonoBehaviour
{
    [SerializeField] private GameObject[] _bonusPrefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 10f, 10f);
    }
    private void Spawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-4f, 4f), 6, Random.Range(-5.45f, 0));
        Instantiate(_bonusPrefab[Random.Range(0,_bonusPrefab.Length)], randomSpawnPosition, Quaternion.identity); ;
    }
}
