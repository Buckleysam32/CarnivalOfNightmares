using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerBluffingDeath : MonoBehaviour
{

    public int playerNUM = 0;
    public bool timesUp = false;
    public bool bluffRound = true;
    public float roundTime = 30;
    public ClownAI ClownBrain;



    //Rock = 0
    //Paper = 1
    //Scissors = 2


    // Start is called before the first frame update
    void Start()
    {
        timesUp = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (timesUp == false)
        {
            roundTime -= Time.deltaTime;
        }

        if (roundTime <= 0)
        {
            bluffRound = false;
            ClownBrain.playerbluffRound = false;

            // give the bluff vaules to the clown ai

            roundTime = 30;
        }



        if (timesUp == false)
        {
            if (bluffRound == true)
            {
                if (playerNUM == 1)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        ClownBrain.player1bluff = 0;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        ClownBrain.player1bluff = 1;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        ClownBrain.player1bluff = 2;

                        //change sprite to selected item

                        //play sfx 
                    }
                }
            }
            else// after bluff round is over
            {
                if (playerNUM == 1)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        ClownBrain.player1hand = 0;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        ClownBrain.player1hand = 1;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        ClownBrain.player1hand = 2;

                        //change sprite to selected item

                        //play sfx 
                    }
                }
            }
            //end of p1 controlls





        }

        //PLAYER 2



        //PLAYER 2


        //ADD STUFF


    }
}
