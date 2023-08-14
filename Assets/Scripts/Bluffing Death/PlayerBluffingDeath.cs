using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PlayerBluffingDeath : MonoBehaviour
{

    public int playerNUM = 0;
    public ClownAI ClownBrain;
    public bool playerbluffRound = true;
    public SpriteRenderer SpriteRenderer;
    public Sprite RockIcon, PaperIcon, ScissorsIcon, RockHand, PaperHand, ScissorsHand, RockThink, PaperThink, ScissorsThink, wait;
    public bool unkillable;
    public bool waiting = false;
    public int frowhands = 4;
    public int thinkhands = 4;
    public bool Pause = false;


    //Rock = 0
    //Paper = 1
    //Scissors = 2


    // Start is called before the first frame update
    void Start()
    {
    }


    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3);
        
        SpriteRenderer.sprite = wait;
        yield return new WaitForSeconds(3);

        SpriteRenderer.sprite = RockIcon;
    }

    // Update is called once per frame
    void Update()
    {


        if (frowhands == 0)
        {
            SpriteRenderer.sprite = RockHand;
            StartCoroutine(Wait());
        }
        else if (frowhands == 1)
        {
            SpriteRenderer.sprite = PaperHand;
            StartCoroutine(Wait());
        }
        else if (frowhands == 2)
        {
            SpriteRenderer.sprite = ScissorsHand;
            StartCoroutine(Wait());
        }
        else
        {
            //do nothing
        }
        frowhands = 4;



        //thinking art
        if (thinkhands == 0)
        {
            SpriteRenderer.sprite = RockThink;
        }
        else if (thinkhands == 1)
        {
            SpriteRenderer.sprite = PaperThink;
        }
        else if (thinkhands == 2)
        {
            SpriteRenderer.sprite = ScissorsThink;
        }
        else
        {
            //do nothing
        }
        thinkhands = 4;





        if (playerbluffRound == true && Pause == false)
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
        else if (Pause == false)// after bluff round is over
        {
            //player 1                  
            if (playerNUM == 1)
            {
                //ROCK
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    ClownBrain.player1hand = 0;

                    //change sprite to selected item
                    SpriteRenderer.sprite = RockThink;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.W))
                {
                    ClownBrain.player1hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperThink;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ClownBrain.player1hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsThink;
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
                    SpriteRenderer.sprite = RockThink;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.T))
                {
                    ClownBrain.player2hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperThink;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    ClownBrain.player2hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsThink;
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
                    SpriteRenderer.sprite = RockThink;
                    //play sfx 
                }
                //PAPPER
                if (Input.GetKeyDown(KeyCode.I))
                {
                    ClownBrain.player3hand = 1;

                    //change sprite to selected item
                    SpriteRenderer.sprite = PaperThink;
                    //play sfx 
                }
                //SCISSORS 
                if (Input.GetKeyDown(KeyCode.O))
                {
                    ClownBrain.player3hand = 2;

                    //change sprite to selected item
                    SpriteRenderer.sprite = ScissorsThink;
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
