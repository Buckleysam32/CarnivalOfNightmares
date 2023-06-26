using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Balloon : MonoBehaviour
{
    public float lungs = 0f;
    public float balloon = 0f;
    public float deflationTimer = 1f;
    public float Inhale = 0f;
    public float Exhale = 0f;
    public float movement = 0f;
    public bool finished = false;


    // Start is called before the first frame update
    void Start()
    {
        finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && finished == false)
        {

            if (Inhale == 0f)
            {
                Inhale += 0.75f;
            }
            else
            {
                Inhale += 1.75f;
            }

            Exhale = 0;
            lungs += Inhale;

            // check for overflow
            if (lungs > 30)
            {
                lungs = 30;
            }

        }

        if (Input.GetKeyDown(KeyCode.O) && finished == false)
        {
            if (Exhale == 0f)
            {
                Exhale += 0.75f;
            }
            else
            {
                Exhale += 1.75f;
            }

            Inhale = 0;


            if (lungs >= Exhale + 0.25)
            {
                balloon += Exhale;

                lungs -= Exhale + 0.25f;

                updateBalloon();

            }

        }







        // Balloon deflation overtime
        deflationTimer -= Time.deltaTime;
        if (deflationTimer <= 0f && finished == false)
        {

            balloon -= 0.95f;

            if (balloon < 0f)
            {
                balloon = 0f;
            }
            // Reset the timer
            deflationTimer = 1f;
            updateBalloon();
        }

        //Debug.Log(" lungs " + lungs + " balloon " + balloon + " Inhale " + Inhale + " Exhale " + Exhale + " movement " + movement + " balloonPercent " );
    }


    void updateBalloon()// well its messy but it works cleen this up later
    {
        //balloon end
        // Convert balloon value to percentage
        //   balloonPercent = balloon * 10f;
        // Calculate movement based on percentage
        movement = balloon / 18.5f;


        // move X position based on balloon value
        transform.position = new Vector3(movement, transform.position.y, transform.position.z);




        if (movement >= 18.5f)
        {
            Debug.Log("finish");
            finished = true;
        }

    }


}
