using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float minSpawnRate = 0.5f;
    [SerializeField] private float maxSpawnRate = 2.0f;

    [SerializeField] private float spawnRateIncreaseTime = 5f;
    [SerializeField] private float spawnRateIncreaseAmount = 0.1f;

    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private bool canSpawn = true;


    private void Start()
    {
        StartCoroutine(Spawner());

    }

    private IEnumerator Spawner()
    {
        while (canSpawn)
        {

                float spawnRate = Random.Range(minSpawnRate, maxSpawnRate);
                yield return new WaitForSeconds(spawnRate);

                Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            if(minSpawnRate > 0.2f)
            {
                minSpawnRate -= spawnRateIncreaseAmount;
                maxSpawnRate -= spawnRateIncreaseAmount;
            }

        }
    }



}