using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Balloon : MonoBehaviour
{
    private float lungs = 0f;
    private float balloon = 0f;
    private float deflationTimer = 1f;
    private float Inhale = 0f;
    private float movement = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

            Inhale += 0.25f;
            lungs += 1 + Inhale;
            if (lungs > 10)
            {
                lungs = 10;
            }

        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Inhale = 0;
            if (lungs >= 1.25)
            {
                balloon += (0.75f);
                lungs -= 1.25f;

            }

        }




        // Balloon deflation
        deflationTimer -= Time.deltaTime;
        if (deflationTimer <= 0f)
        {
            balloon -= 0.20f;
            if (balloon < 0f)
            {
                balloon = 0f;
            }
            // Reset the timer
            deflationTimer = 1f;
        }

        //balloon end
        // Convert balloon value to percentage
        float balloonPercent = balloon * 100f;

        // Calculate movement based on percentage
        movement = balloonPercent * 16.5f;

        // Increase X position based on balloon value
        transform.position += new Vector3(movement, 0f, 0f);

        Debug.Log(" lungs " + lungs + " balloon " + balloon + " Inhale " + Inhale);
    }

    // move the balloon hitbox to the right





    private void OnTriggerEnter(Collider other)
    {
        
    }

}
