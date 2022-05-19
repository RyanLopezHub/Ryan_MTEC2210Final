using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshPro timerText;
    private Timer timer;
    
       
    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();
        }
    }

    

}
