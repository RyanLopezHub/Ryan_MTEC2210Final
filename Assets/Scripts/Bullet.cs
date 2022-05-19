using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed, timer;

    public GameObject enemyRespawnPrefab;
    public GameObject enemyRespawnPrefab2;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime; //allows bullet to go up
        timer -= Time.deltaTime; //destroys bullets to save memory
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Score.scoreAmount += 1;
            Destroy(other.gameObject);
            Vector3 enemyRespawnPosition = new Vector3(Random.Range(-8,8), 6, 0); //spawns in enememies along xaxis
            Vector3 enemyRespawnPosition2 = new Vector3(Random.Range(-4, 4), 6, 0);
            Instantiate(enemyRespawnPrefab, enemyRespawnPosition, Quaternion.identity);
            Instantiate(enemyRespawnPrefab2, enemyRespawnPosition2, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
