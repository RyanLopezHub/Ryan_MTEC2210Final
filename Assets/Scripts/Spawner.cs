using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform spawnpoint;

    private int rand;

    public float startTimeBetweenSpawns;
    public float timeBetweenSpawns;

    private void Start()
    {
        timeBetweenSpawns = startTimeBetweenSpawns;
    }

    private void Update()
    {
        if (timeBetweenSpawns <= 0)
        {
            rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], spawnpoint.transform.position, Quaternion.identity);
            timeBetweenSpawns = startTimeBetweenSpawns;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
