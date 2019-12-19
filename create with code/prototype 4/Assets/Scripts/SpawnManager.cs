﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenorateSpawnPosition(), enemyPrefab.transform.rotation);
        spawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {
        
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
