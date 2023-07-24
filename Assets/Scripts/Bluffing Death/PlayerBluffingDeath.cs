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
                //player 1                
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

                //player 2                
                if (playerNUM == 2)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        ClownBrain.player2bluff = 0;

                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        ClownBrain.player2bluff = 1;

                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.Y))
                    {
                        ClownBrain.player2bluff = 2;

                    }
                }

                //player 3                
                if (playerNUM == 3)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.U))
                    {
                        ClownBrain.player3bluff = 0;

                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.I))
                    {
                        ClownBrain.player3bluff = 1;
                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.O))
                    {
                        ClownBrain.player3bluff = 2;

                    }
                }
            }
            else// after bluff round is over
            {
                //player 1                  
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

                //player 2                
                if (playerNUM == 1)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        ClownBrain.player2hand = 0;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        ClownBrain.player2hand = 1;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.Y))
                    {
                        ClownBrain.player2hand = 2;

                        //change sprite to selected item

                        //play sfx 
                    }
                }

                //player 3               
                if (playerNUM == 3)
                {
                    //ROCK
                    if (Input.GetKeyDown(KeyCode.U))
                    {
                        ClownBrain.player3hand = 0;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //PAPPER
                    if (Input.GetKeyDown(KeyCode.I))
                    {
                        ClownBrain.player3hand = 1;

                        //change sprite to selected item

                        //play sfx 
                    }
                    //SCISSORS 
                    if (Input.GetKeyDown(KeyCode.O))
                    {
                        ClownBrain.player3hand = 2;

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
