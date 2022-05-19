using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed, timer;
    
    
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
}
