using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Balloon : MonoBehaviour
{
    private float lungs = 0f;
    private float deflationTimer = 1f;
    private float Inhale = 0f;
    private float Exhale = 0f;
    private float movement = 0f;
    private float AirMovement = 0f;
    private bool finished = false;
    public AudioSource soundSorce;
    public AudioClip finish, breathingIn, breathingInMax, breathingOut, breathingOutMax;
    public airBubble airBuble;
    public Player_Balloon otherplayer1;
    public Player_Balloon otherplayer2;
    public timer stopTimer;
    public TextMeshProUGUI winnerText;
    public int playerNUM = 0;
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
            if (Input.GetKeyDown(KeyCode.Q) && finished == false)
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

            if (Input.GetKeyDown(KeyCode.W) && finished == false)
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
            if (Input.GetKeyDown(KeyCode.V) && finished == false)
            {
                //look at playerNUM 1 to see comments on this code


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

            if (Input.GetKeyDown(KeyCode.B) && finished == false)
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
                    lungs -= Exhale + 0.25f;

                    //sfx breath out
                    soundSorce.clip = breathingOut;
                    soundSorce.Play();

                    Instantiate(airBubble, new Vector3(0, transform.position.y, transform.position.z), Quaternion.identity);

                    if (airBuble != null)
                    {
                        airBuble.airAmount = Exhale;
                    }

                }
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
            if (Input.GetKeyDown(KeyCode.I) && finished == false)
            {
                //look at playerNUM 1 to see comments on this code


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
                    lungs -= Exhale + 0.25f;

                    //sfx breath out
                    soundSorce.clip = breathingOut;
                    soundSorce.Play();

                    Instantiate(airBubble, new Vector3(0, transform.position.y, transform.position.z), Quaternion.identity);

                    if (airBuble != null)
                    {
                        airBuble.airAmount = Exhale;
                    }

                }
                else
                {
                    //sfx breath out max
                    soundSorce.clip = breathingOutMax;
                    soundSorce.Play();
                }

            }
        }

        // Balloon deflation overtime
        if (finished == false)
        {
            deflationTimer -= Time.deltaTime;
        }
            
        if (deflationTimer <= 0f)// && finished == false)
        {        
            movement -= 0.095f;
            //IF LESS THE ZERO SET TO ZERO
            if (movement < 0f)
            {
                movement = 0f;
            }
            // move X position based on balloon value
            transform.position = new Vector3(movement, transform.position.y, transform.position.z);

            // Reset the timer
            deflationTimer = 1f;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (movement >= 15.5f && finished == false)
        {
            //finish the race
            finished = true;

            // STOP OTHER PLAYERS (MULTIPLAYER MODE)
            if (otherplayer1 != null)
            {
                otherplayer1.finished = finished;
            }
            if (otherplayer2 != null)
            {
                otherplayer2.finished = finished;
            }

            // show the time in seconds (SINGAL PLAYER MODE)
            if (winnerText != null)
            {
                winnerText.text = "Player " + playerNUM + " Won!".ToString();
            }
            if (stopTimer != null)//  (SINGAL PLAYER MODE)
            {
                stopTimer.finishedTimer = finished;
            }

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
