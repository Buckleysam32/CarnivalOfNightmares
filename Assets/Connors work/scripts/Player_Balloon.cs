using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Balloon : MonoBehaviour
{
    public float lungs = 0f;
    public float deflationTimer = 1f;
    public float Inhale = 0f;
    public float Exhale = 0f;
    public float movement = 0f;
    public float AirMovement = 0f;
    public bool finished = false;
    public AudioSource soundSorce;
    public AudioClip finish, breathingIn, breathingInMax, breathingOut, breathingOutMax;
    public airBubble airBuble;

    public int playerNUM;


    //private 

    public GameObject airBubble;

    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        airBubble airBuble = airBubble.GetComponent<airBubble>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNUM == 1)
        {
            if (Input.GetKeyDown(KeyCode.Q) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                //this is to add a mutiplyer for the inhale mutiplyer 

                // if inhale is 0 add a .75 mutiplyer to it
                if (Inhale == 0f)
                {
                    Inhale += 0.75f;
                }
                // else if the inhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Inhale += 1.75f;
                }

                // set exhale to 0 as inhale is incresed 
                Exhale = 0;

                // lungs are the max cappasity for the air the player can hold
                lungs += Inhale;

                // check for overflow

                // the curently set max value for the lungs
                if (lungs > 30)
                {
                    lungs = 30;
                    //sfx breath in max

                    soundSorce.clip = breathingInMax;
                    soundSorce.Play();
                }
                else
                {
                    //sfx breath in
                    soundSorce.clip = breathingIn;
                    soundSorce.Play();
                }

            }

            if (Input.GetKeyDown(KeyCode.W) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                // if Exhale is 0 add a .75 mutiplyer to it
                if (Exhale == 0f)
                {
                    Exhale += 0.75f;
                }
                // else if the Exhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Exhale += 1.75f;
                }

                // set Inhale to 0 as Exhale is incresed 
                Inhale = 0;

                // check if lungs has enogh air to remove or not

                // if there is air that can be taken
                if (lungs >= Exhale + 0.25)
                {
                    lungs -= Exhale + 0.25f;

                    //sfx breath out
                    soundSorce.clip = breathingOut;
                    soundSorce.Play();

                    //SPAWN IN AIR BUBBLE
                    Instantiate(airBubble, new Vector3(0, transform.position.y, transform.position.z), Quaternion.identity);
                    // set the air bubble value to the value added

                    //set the air bubble size to the Exhale vaule
                    if (airBuble != null)
                    {
                        airBuble.airAmount = Exhale;
                    }


                }
                //if the air is too small 
                else
                {
                    //sfx breath out max
                    soundSorce.clip = breathingOutMax;
                    soundSorce.Play();
                }

            }
        }
        if (playerNUM == 2)
        {
            if (Input.GetKeyDown(KeyCode.V) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                //this is to add a mutiplyer for the inhale mutiplyer 

                // if inhale is 0 add a .75 mutiplyer to it
                if (Inhale == 0f)
                {
                    Inhale += 0.75f;
                }
                // else if the inhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Inhale += 1.75f;
                }

                // set exhale to 0 as inhale is incresed 
                Exhale = 0;

                // lungs are the max cappasity for the air the player can hold
                lungs += Inhale;

                // check for overflow

                // the curently set max value for the lungs
                if (lungs > 30)
                {
                    lungs = 30;
                    //sfx breath in max

                    soundSorce.clip = breathingInMax;
                    soundSorce.Play();
                }
                else
                {
                    //sfx breath in
                    soundSorce.clip = breathingIn;
                    soundSorce.Play();
                }

            }

            if (Input.GetKeyDown(KeyCode.B) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                // if Exhale is 0 add a .75 mutiplyer to it
                if (Exhale == 0f)
                {
                    Exhale += 0.75f;
                }
                // else if the Exhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Exhale += 1.75f;
                }

                // set Inhale to 0 as Exhale is incresed 
                Inhale = 0;

                // check if lungs has enogh air to remove or not

                // if there is air that can be taken
                if (lungs >= Exhale + 0.25)
                {
                    lungs -= Exhale + 0.25f;

                    //sfx breath out
                    soundSorce.clip = breathingOut;
                    soundSorce.Play();

                    //SPAWN IN AIR BUBBLE
                    Instantiate(airBubble, new Vector3(0, transform.position.y, transform.position.z), Quaternion.identity);
                    // set the air bubble value to the value added

                    //set the air bubble size to the Exhale vaule
                    if (airBuble != null)
                    {
                        airBuble.airAmount = Exhale;
                    }


                }
                //if the air is too small 
                else
                {
                    //sfx breath out max
                    soundSorce.clip = breathingOutMax;
                    soundSorce.Play();
                }

            }
        }
        if (playerNUM == 3)
        {
            if (Input.GetKeyDown(KeyCode.I) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                //this is to add a mutiplyer for the inhale mutiplyer 

                // if inhale is 0 add a .75 mutiplyer to it
                if (Inhale == 0f)
                {
                    Inhale += 0.75f;
                }
                // else if the inhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Inhale += 1.75f;
                }

                // set exhale to 0 as inhale is incresed 
                Exhale = 0;

                // lungs are the max cappasity for the air the player can hold
                lungs += Inhale;

                // check for overflow

                // the curently set max value for the lungs
                if (lungs > 30)
                {
                    lungs = 30;
                    //sfx breath in max

                    soundSorce.clip = breathingInMax;
                    soundSorce.Play();
                }
                else
                {
                    //sfx breath in
                    soundSorce.clip = breathingIn;
                    soundSorce.Play();
                }

            }

            if (Input.GetKeyDown(KeyCode.O) && finished == false)// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller// update the controls for a controller
            {
                // if Exhale is 0 add a .75 mutiplyer to it
                if (Exhale == 0f)
                {
                    Exhale += 0.75f;
                }
                // else if the Exhale modifyer is not 0 then add a 1.75 mutiplyer
                else
                {
                    Exhale += 1.75f;
                }

                // set Inhale to 0 as Exhale is incresed 
                Inhale = 0;

                // check if lungs has enogh air to remove or not

                // if there is air that can be taken
                if (lungs >= Exhale + 0.25)
                {
                    lungs -= Exhale + 0.25f;

                    //sfx breath out
                    soundSorce.clip = breathingOut;
                    soundSorce.Play();

                    //SPAWN IN AIR BUBBLE
                    Instantiate(airBubble, new Vector3(0, transform.position.y, transform.position.z), Quaternion.identity);
                    // set the air bubble value to the value added

                    //set the air bubble size to the Exhale vaule
                    if (airBuble != null)
                    {
                        airBuble.airAmount = Exhale;
                    }


                }
                //if the air is too small 
                else
                {
                    //sfx breath out max
                    soundSorce.clip = breathingOutMax;
                    soundSorce.Play();
                }

            }
        }

        // Balloon deflation overtime
        deflationTimer -= Time.deltaTime;
        if (deflationTimer <= 0f && finished == false)
        {

            movement -= 0.095f;

            if (movement < 0f)
            {
                movement = 0f;
            }
            // Reset the timer
            deflationTimer = 1f;

            // move X position based on balloon value
            transform.position = new Vector3(movement, transform.position.y, transform.position.z);


        }

        //Debug.Log(" lungs " + lungs + " Inhale " + Inhale + " Exhale " + Exhale + " movement " + movement + " balloonPercent " );
    }

    /*
    void updateBalloon()// well its messy but it works cleen this up later
    {
        // Calculate movement based on percentage
        movement = balloon / 18.5f;

        // move X position based on balloon value
        transform.position = new Vector3(movement, transform.position.y, transform.position.z);




        if (movement >= 17.5f)
        {
            Debug.Log("finish");
            finished = true;
            // sfx finish
            soundSorce.clip = finish;
            soundSorce.Play();
        }

    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (movement >= 16.5f && finished == false)
        {
            //Debug.Log("finish");
            finished = true;
            // sfx finish
            soundSorce.clip = finish;
            soundSorce.Play();
        }
        else
        {


            // Calculate movement based on percentage
            movement += airBuble.airAmount / 17.5f;// the air bubbles value / 17

            // move X position based on balloon value
            transform.position = new Vector3(movement, transform.position.y, transform.position.z);

        }
    }

}
