using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject alienPrefab;
    public Transform[] alienSpawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        SpawnAlien();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAlien()
    {
        int index = Random.Range(0, alienSpawnPoints.Length);
        Vector2 spawnPos = alienSpawnPoints[index].position;

        GameObject alien = Instantiate(alienPrefab, spawnPos, Quaternion.identity);

        alien.GetComponent<AlienMovement>().speed = Random.Range(3.0f, 5.0f);
    }
}
