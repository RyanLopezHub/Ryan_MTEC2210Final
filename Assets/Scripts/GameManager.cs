using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] enemySpawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, enemySpawnPoints.Length);
        Vector3 spawnPos = enemySpawnPoints[index].position;
        
        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        enemy.GetComponent<EnemyMovement>().speed = Random.Range(3.0f, 6.0f);

        
    }
}
