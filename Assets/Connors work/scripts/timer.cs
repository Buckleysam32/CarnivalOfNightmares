using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class timer : MonoBehaviour
{
    public float Timer = 1f;
    public bool finishedTimer = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }





    // Update is called once per frame
    void Update()
    {

        if (finishedTimer == false)
        {
            Timer += Time.deltaTime;
            Debug.Log("timer is " + Timer);
        }

    }
}
