using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ClownAI : MonoBehaviour
{
    public PlayerBluffingDeath player1;
    public PlayerBluffingDeath player2;
    public PlayerBluffingDeath player3;
    public int player1bluff = 0;
    public int player2bluff = 0;
    public int player3bluff = 0;
    public int player1hand = 0;
    public int player2hand = 0;
    public int player3hand = 0;
    public int clownhandforPlayer1 = 0;
    public int clownhandforPlayer2 = 0;
    public int clownhandforPlayer3 = 0;
    public int player1successfulbluff = 0;
    public int player2successfulbluff = 0;
    public int player3successfulbluff = 0;
    public int clownHandForAll = 0;
    public bool paused = false;
    public int roundNum = 1;
    public int halfGame = 0;

    public bool timesUp = false;// when the game is over
    public float roundTime = 10;
    public bool bluffRound = true;
    public TextMeshProUGUI roundInticator;


    public SpriteRenderer SpriteRenderer;
    public Sprite RockIcon, PaperIcon, ScissorsIcon, thinking;


    //Rock = 0
    //Paper = 1
    //Scissors = 2


    // Start is called before the first frame update
    void Start()
    {
        timesUp = false;
    }

    // Update is called once per frame
    void Update()// look at this link https://youtu.be/sw7UAZNgGg8
    {


        // check if game is over
        if (roundNum >= 6 )
        {
            timesUp = true;
            Debug.Log("players won");
        }





        if (paused == true)
        {
            SpriteRenderer.sprite = thinking;
            paused = false;
            //roundNum += 1;
        }

        if (timesUp == false && paused == false)
        {
            roundTime -= Time.deltaTime;
        }

        //to whole num
        int IntTime = (int)roundTime;

        if (bluffRound == true)
        {
            roundInticator.text = "game " + roundNum + " Bluff Round " + IntTime + " seconds".ToString();
        }
        else if (bluffRound == false)
        {
            roundInticator.text = "game " + roundNum + " Real Round " + IntTime + " seconds".ToString();
        }
        else
        {
            Debug.Log("error on line 70 of clown ai");
        }

        if (roundTime <= 0)
        {
            if (bluffRound == true)
            {
                bluffRound = false;
                player1.playerbluffRound = false;
                player2.playerbluffRound = false;
                player3.playerbluffRound = false;
            }
            else
            {
                bluffRound = true;
                //HAVE CLOWN CHECK RESULTS

                //player 1
                if (player1 != null)
                {
                    if (clownhandforPlayer1 == player1hand)
                    {
                        //Debug.Log("player1 tie");
                        player1successfulbluff += 1;
                    }
                    else if ((clownhandforPlayer1 == 0 && player1hand == 1) || (clownhandforPlayer1 == 1 && player1hand == 2) || (clownhandforPlayer1 == 2 && player1hand == 0))
                    {
                        //Debug.Log("player1 won");
                        player1successfulbluff -= 1;
                        player1.unkillable = true;
                        // add one turn imunity
                    }
                    else
                    {
                        //Debug.Log("player1 lost");
                        // start a fuction that checks if the player dies or not longer are imune 
                        player1.GetComponent<PlayerBluffingDeath>().roundLost();
                    }
                }

                //player 2
                if (player2 != null)
                {
                    if (clownhandforPlayer2 == player2hand)
                    {
                       // Debug.Log("player2 tie");
                        player2successfulbluff += 1;
                    }
                    else if ((clownhandforPlayer2 == 0 && player2hand == 1) || (clownhandforPlayer2 == 1 && player2hand == 2) || (clownhandforPlayer2 == 2 && player2hand == 0))
                    {
                        //Debug.Log("player2 won");
                        player2successfulbluff -= 1;
                        player2.unkillable = true;
                        // add one turn imunity
                    }
                    else
                    {
                       // Debug.Log("player2 lost");
                        player2.GetComponent<PlayerBluffingDeath>().roundLost();
                    }
                }

                //player 3
                if (player3 != null)
                {
                    if (clownhandforPlayer3 == player3hand)
                    {
                        //Debug.Log("player3 tie");
                        player3successfulbluff += 1;
                    }
                    else if ((clownhandforPlayer3 == 0 && player3hand == 1) || (clownhandforPlayer3 == 1 && player3hand == 2) || (clownhandforPlayer3 == 2 && player3hand == 0))
                    {
                       // Debug.Log("player3 won");
                        player3successfulbluff -= 1;
                        player3.unkillable = true;
                        // add one turn imunity
                    }
                    else
                    {
                        //Debug.Log("player3 lost");
                        player3.GetComponent<PlayerBluffingDeath>().roundLost();
                    }
                }

                player1.playerbluffRound = true;
                player2.playerbluffRound = true;
                player3.playerbluffRound = true;

                player1bluff = player1hand;
                player2bluff = player2hand;
                player3bluff = player3hand;



                if (clownHandForAll == 0)
                {
                    SpriteRenderer.sprite = RockIcon;
                }

                if (clownHandForAll == 1)
                {
                    SpriteRenderer.sprite = PaperIcon;
                }

                if (clownHandForAll == 2)
                {
                    SpriteRenderer.sprite = ScissorsIcon;
                }

                StartCoroutine(Wait());





            }


            if (halfGame != 1)
            {
                halfGame += 1;
                //Debug.Log("halfgame called");
            }
            else
            {
                roundNum += 1;
                halfGame = 0;
            }






            roundTime = 10;
        }


        //check if all players are dead
        if (player1 == null && player2 == null && player3 == null)
        {
            Debug.Log("all players lost game over");
            timesUp = true;
        }



        // do a for loop for each players input and do the math

        if (bluffRound == true)// when the clown get there first bluff they will aim for a draw this is make it easy for the next round to be prodiced baced off the results
        {
            if (player1 != null)
            {
                //clowns inisual guess
                if (player1bluff == 0)//rock
                {
                    clownhandforPlayer1 = 1;
                }
                if (player1bluff == 1)//PAPPER
                {
                    clownhandforPlayer1 = 2;
                }
                if (player1bluff == 2)//SCISSORS
                {
                    clownhandforPlayer1 = 0;
                }

                //plus 1 to the clown hand to try to keep up with and try to be a step head
                for (int i = 0; i <= player1successfulbluff; i++)
                {
                    clownhandforPlayer1 += +1;

                    if (clownhandforPlayer1 > 2)
                    {
                        clownhandforPlayer1 = 0;
                    }
                }
            }


            if (player2 != null)
            {
                if (player2bluff == 0)//rock
                {
                    clownhandforPlayer2 = 1;
                }
                if (player2bluff == 1)//PAPPER
                {
                    clownhandforPlayer2 = 2;
                }
                if (player2bluff == 2)//SCISSORS
                {
                    clownhandforPlayer2 = 0;
                }

                //add in a for loop where player1successfulbluff + 1 to the code untill there is non left
                for (int i = 0; i <= player2successfulbluff; i++)
                {
                    clownhandforPlayer2 += +1;

                    if (clownhandforPlayer2 > 2)
                    {
                        clownhandforPlayer2 = 0;
                    }
                }
            }


            if (player3 != null)
            {
                if (player3bluff == 0)//rock
                {
                    clownhandforPlayer3 = 1;
                }
                if (player3bluff == 1)//PAPPER
                {
                    clownhandforPlayer3 = 2;
                }
                if (player3bluff == 2)//SCISSORS
                {
                    clownhandforPlayer3 = 0;
                }

                //add in a for loop where player1successfulbluff + 1 to the code untill there is non left
                for (int i = 0; i <= player3successfulbluff; i++)
                {
                    clownhandforPlayer3 += +1;

                    if (clownhandforPlayer3 > 2)
                    {
                        clownhandforPlayer3 = 0;
                    }
                }
            }



        }
        else
        {
            // check results of all three and see which has dubble ups of the same number

            //clownhandforPlayer1 clownhandforPlayer2 clownhandforPlayer3


            //change all output clownhands to one option baced of the results (the clown dose not have 3 hands)
            //Dictionary<clownhandforPlayer1, clownhandforPlayer2, clownhandforPlayer3>



            //this is a guide so i won't miss a certain combination of players

            // 1 = not null 0 = null

            //111
            //110
            //101
            //100
            //011
            //010
            //001

            if (player1 != null && player2 != null && player3 != null)
            {
                bestChoice(new int[] { clownhandforPlayer1, clownhandforPlayer2, clownhandforPlayer3 });
            }
            else if (player1 != null && player2 != null && player3 == null)
            {
                bestChoice(new int[] { clownhandforPlayer1, clownhandforPlayer2 });
            }
            else if (player1 != null && player2 == null && player3 != null)
            {
                bestChoice(new int[] { clownhandforPlayer1, clownhandforPlayer3 });
            }
            else if (player1 != null && player2 == null && player3 == null)
            {
                bestChoice(new int[] { clownhandforPlayer1 });
            }
            else if (player1 == null && player2 != null && player3 != null)
            {
                bestChoice(new int[] { clownhandforPlayer2, clownhandforPlayer3 });
            }
            else if (player1 == null && player2 != null && player3 == null)
            {
                bestChoice(new int[] { clownhandforPlayer2 });
            }
            else if (player1 == null && player2 == null && player3 != null)
            {
                bestChoice(new int[] { clownhandforPlayer3 });
            }
            else if (player1 == null && player2 == null && player3 == null)
            {
                Debug.Log("all players lost game over");
                timesUp = true;
            }
            else
            {
                Debug.Log("error at 457");
            }

        }

    }

    IEnumerator Wait()
    {
        timesUp = true;
        yield return new WaitForSeconds(3);
        paused = true;
        timesUp = false;

        //roundNum += 1;
    }

    void bestChoice(int[] numbers)
    {
        Dictionary<int, int> bestChoice = new Dictionary<int, int>();
        foreach (int number in numbers)
        {
            if (bestChoice.ContainsKey(number))
            {
                bestChoice[number]++;
            }
            else
            {
                bestChoice[number] = 1;
            }
        }
        int maxCount = bestChoice.Values.Max();
        clownHandForAll = bestChoice.Where(x => x.Value == maxCount).OrderByDescending(x => x.Key).First().Key;
    }

}
