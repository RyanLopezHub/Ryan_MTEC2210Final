using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreValue;
    private TextMeshProUGUI scoreCounterText;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounterText.text = scoreValue.ToString();
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            scoreValue += 10;
        }
    }

}
