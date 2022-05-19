using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 4.0f;

    

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //PLAYER MOVEMENT
        float xMove = Input.GetAxisRaw("Horizontal"); //player moves across x axis

        float xMovement = xMove * speed * Time.deltaTime;

        transform.Translate(xMovement, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision) //if player is hit by enemy, scene resets
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Player has died");
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
