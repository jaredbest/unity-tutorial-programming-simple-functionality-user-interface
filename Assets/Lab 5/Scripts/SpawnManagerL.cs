using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerL : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    float zEnemySpawn = 12.0f;
    float xSpawnRange = 16.0f;
    float zPowerupRange = 5.0f;
    float ySpawn = 0.75f;

    float powerupSpawnTime = 5.0f;
    float enemySpawnTime = 1.0f;
    float startDelay = 1.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowewrup", startDelay, powerupSpawnTime);
    }

    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowewrup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
