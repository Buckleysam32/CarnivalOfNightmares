using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class PlayerBluffingDeath : MonoBehaviour
{

    public int playerNUM = 0;
    public ClownAI ClownBrain;
    public bool playerbluffRound = true;
    public SpriteRenderer SpriteRenderer;
    public Sprite RockIcon, PaperIcon, ScissorsIcon;
    public bool unkillable;

    //Rock = 0
    //Paper = 1
    //Scissors = 2


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playerbluffRound == true)
        {
            //player 1                
            if (playerNUM == 1)
            {
                //ROCK
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    ClownBrain.player1bluff = 0;

                    //change sprite to selected item
                    SpriteRenderer.sprite = RockIcon;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.W))
                {
                    ClownBrain.player1bluff = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperIcon;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ClownBrain.player1bluff = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsIcon;
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

                    SpriteRenderer.sprite = RockIcon;
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.T))
                {
                    ClownBrain.player2bluff = 1;

                    SpriteRenderer.sprite = PaperIcon;
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    ClownBrain.player2bluff = 2;

                    SpriteRenderer.sprite = ScissorsIcon;
                }
            }

            //player 3                
            if (playerNUM == 3)
            {
                //ROCK
                if (Input.GetKeyDown(KeyCode.U))
                {
                    ClownBrain.player3bluff = 0;

                    SpriteRenderer.sprite = RockIcon;
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.I))
                {
                    ClownBrain.player3bluff = 1;

                    SpriteRenderer.sprite = PaperIcon;
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.O))
                {
                    ClownBrain.player3bluff = 2;

                    SpriteRenderer.sprite = ScissorsIcon;

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
                    SpriteRenderer.sprite = RockIcon;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.W))
                {
                    ClownBrain.player1hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperIcon;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ClownBrain.player1hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsIcon;
                    //play sfx 
                }
            }

            //player 2                
            if (playerNUM == 2)
            {
                //ROCK
                if (Input.GetKeyDown(KeyCode.R))
                {
                    ClownBrain.player2hand = 0;

                    //change sprite to selected item
                    SpriteRenderer.sprite = RockIcon;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.T))
                {
                    ClownBrain.player2hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperIcon;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    ClownBrain.player2hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsIcon;
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
                    SpriteRenderer.sprite = RockIcon;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.I))
                {
                    ClownBrain.player3hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperIcon;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.O))
                {
                    ClownBrain.player3hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsIcon;
                    //play sfx 
                }
            }

        }




    }

    public void roundLost()
    {


        //Debug.Log("player1.GetComponent<PlayerBluffingDeath>().roundLost(); was called");
        if (unkillable == true)
        {
            unkillable = false;
        }
        else
        {
            Destroy(gameObject);
        }

    }

}
