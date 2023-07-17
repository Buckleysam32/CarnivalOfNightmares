using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;



public class timer : MonoBehaviour
{
    public float Timer = 0f;
    public bool finishedTimer = false;
    public TextMeshProUGUI timerText;
    
    // Update is called once per frame
    void Update()
    {
        //check if the timer should still be going
        if (finishedTimer == false)
        {
            Timer += Time.deltaTime;

            //to whole num
            int IntTime = (int)Timer;

            // show the time in seconds
            timerText.text = IntTime.ToString();
        }

    }
}
