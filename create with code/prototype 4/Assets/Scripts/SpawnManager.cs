using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerup;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenorateSpawnPosition(), enemyPrefab.transform.rotation);
        Instantiate(powerup, GenorateSpawnPosition(), powerup.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            Instantiate(powerup, GenorateSpawnPosition(), powerup.transform.rotation);
            waveNumber++;
            spawnEnemyWave(waveNumber);
        }
    } 


    private Vector3 GenorateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    void spawnEnemyWave(int enemysToSpawn)
    {
        for (int i = 0; i < enemysToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenorateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
