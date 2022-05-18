using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{

    public float speed = 5;

    void Update()
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0, -yValue, 0);
       
    } 
}
