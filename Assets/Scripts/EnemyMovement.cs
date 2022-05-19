using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3;

    // Update is called once per frame
    void Update()
    {
        float yVaule = speed * Time.deltaTime;
        transform.Translate(0, -yVaule, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            string currentSceneName = SceneManager.GetActiveScene().name;  //Resets Game
            SceneManager.LoadScene(currentSceneName);
        }
        
        if (collision.transform.tag == "Bullet") //Bullets eliminate enemy
        {
            Destroy(gameObject);
        }
    }
}
