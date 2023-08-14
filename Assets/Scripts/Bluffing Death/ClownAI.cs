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
    public int roundNum = 1;
    public bool halfGame = false;

    public bool gamerOver = false;

    public bool timesUp = false;// when the game is over
    public float roundTime = 10;
    public bool bluffRound = true;
    public TextMeshProUGUI roundInticator;

    public SpriteRenderer clownIcon;
    public SpriteRenderer SpriteRenderer;
    public Sprite RockIcon, PaperIcon, ScissorsIcon, thinking, won, lost, bubbleRock, bubblePaper, bubbleSiccors, bubbleNull;

    public AudioSource soundSorce;
    public AudioClip bluffRoundEnd, realRoundEnd, gameWon, gameLost;



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
        int IntTime = (int)roundTime;
        if (timesUp == false && gamerOver == false)
        {
            roundTime -= Time.deltaTime;

            if (bluffRound == true)
            {
                roundInticator.text = "Game " + roundNum + " Bluff Round " + IntTime + " seconds".ToString();
            }
            else if (bluffRound == false)
            {
                roundInticator.text = "Game " + roundNum + " Real Round " + IntTime + " seconds".ToString();
            }
            else
            {
                Debug.Log("error on line 70 of clown ai");
            }
        }

        //to whole num


        if (roundTime <= 0 && gamerOver == false)
        {
            //round over sfx
            soundSorce.clip = bluffRoundEnd;
            soundSorce.Play();

            if (bluffRound == true)
            {
                //setup next round
                bluffRound = false;
                player1.playerbluffRound = false;
                player2.playerbluffRound = false;
                player3.playerbluffRound = false;

                //soundSorce.clip = bluffRoundEnd;

                //thinking art players
                player1.thinkhands = player1bluff;
                player2.thinkhands = player2bluff;
                player3.thinkhands = player3bluff;

            }
            else
            {
                //setup next round
                bluffRound = true;
                player1.playerbluffRound = true;
                player2.playerbluffRound = true;
                player3.playerbluffRound = true;

                //soundSorce.clip = realRoundEnd;

                // update the bluff of the next round to be the same as the curentlly selected option
                player1bluff = player1hand;
                player2bluff = player2hand;
                player3bluff = player3hand;

                StartCoroutine(Wait());//wait 3 seconds then change to thinking art
            }

            if (halfGame != true)
            {
                halfGame = true;
                //Debug.Log("halfgame called");
            }
            else
            {
                roundNum += 1;
                halfGame = false;
            }
            roundTime = 10;
        }

        if (bluffRound == true && gamerOver == false)// when the clown get there first bluff they will aim for a draw this is make it easy for the next round to be prodiced baced off the results
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

            if (player1 != null && player2 != null && player3 != null)// fix the fuction calling code not calling for all pla
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


        //check if all players are dead
        if (player1 == null && player2 == null && player3 == null && gamerOver == false)
        {
            roundInticator.text = "All Players Lost Game Over.".ToString();

            gamerOver = true;
            timesUp = true;
            SpriteRenderer.sprite = won;
            clownIcon.sprite = bubbleNull;

            soundSorce.clip = gameLost;
            soundSorce.Play();
        }

        // five rounds till the game is over
        if (roundNum >= 6 && gamerOver == false)
        {
            roundInticator.text = "Players Won".ToString();



            soundSorce.clip = gameWon;
            soundSorce.Play();

            clownIcon.sprite = bubbleNull;

            SpriteRenderer.sprite = lost;
            gamerOver = true;
            timesUp = true;
        }



    }



    IEnumerator Wait()// make this stop player input for the player script// make this stop player input for the player script// make this stop player input for the player script// make this stop player input for the player script// make this stop player input for the player script
    {
        if (gamerOver == false)
        {
            //pause
            timesUp = true;
            player1.Pause = true;
            player2.Pause = true;
            player3.Pause = true;

            //art for players hands
            player1.frowhands = player1hand;
            player2.frowhands = player2hand;
            player3.frowhands = player3hand;

            //art for clown hand
            if (clownHandForAll == 0)
            {
                SpriteRenderer.sprite = RockIcon;
                clownIcon.sprite = bubbleRock;
            }

            if (clownHandForAll == 1)
            {
                SpriteRenderer.sprite = PaperIcon;
                clownIcon.sprite = bubblePaper;
            }

            if (clownHandForAll == 2)
            {
                SpriteRenderer.sprite = ScissorsIcon;
                clownIcon.sprite = bubbleSiccors;
            }

            Debug.Log("start 3 sec timer");
            yield return new WaitForSeconds(3);
            Debug.Log("end of 3 sec timer");

            //HAVE CLOWN CHECK RESULTS

            //player 1
            if (player1 != null)
            {
                if (clownHandForAll == player1hand)
                {
                    //Debug.Log("player1 tie");
                    player1successfulbluff += 1;
                }
                else if ((clownHandForAll == 0 && player1hand == 1) || (clownHandForAll == 1 && player1hand == 2) || (clownHandForAll == 2 && player1hand == 0))
                {
                    //Debug.Log("player1 won");
                    player1successfulbluff -= 1;
                    player1.unkillable = true;
                    // add one turn imunity
                }
                else
                {
                    //Debug.Log("player1 lost");
                    // start a fuction that checks if the player dies or no longer are imune 
                    player1.GetComponent<PlayerBluffingDeath>().roundLost();
                }
            }

            //player 2
            if (player2 != null)
            {
                if (clownHandForAll == player2hand)
                {
                    // Debug.Log("player2 tie");
                    player2successfulbluff += 1;
                }
                else if ((clownHandForAll == 0 && player2hand == 1) || (clownHandForAll == 1 && player2hand == 2) || (clownHandForAll == 2 && player2hand == 0))
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
                if (clownHandForAll == player3hand)
                {
                    //Debug.Log("player3 tie");
                    player3successfulbluff += 1;
                }
                else if ((clownHandForAll == 0 && player3hand == 1) || (clownHandForAll == 1 && player3hand == 2) || (clownHandForAll == 2 && player3hand == 0))
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

            //wait for next round
            SpriteRenderer.sprite = thinking;
            clownIcon.sprite = bubbleNull;
            timesUp = false;
            player1.Pause = false;
            player2.Pause = false;
            player3.Pause = false;






            //roundNum += 1;
        }

    }

    void bestChoice(int[] clownhandforPlayer)// code fix may or may not be better then old code check later
    {

        Dictionary<int, int> bestChoice = new Dictionary<int, int>();

        foreach (int BluffNumber in clownhandforPlayer)
        {
            if (bestChoice.ContainsKey(BluffNumber))
            {
                bestChoice[BluffNumber]++;
            }
            else
            {
                bestChoice[BluffNumber] = 1;
            }
        }
        int maxCount = bestChoice.Values.Max();
        clownHandForAll = bestChoice.FirstOrDefault(x => x.Value == maxCount).Key;
        Debug.Log("clownhandforall is" + clownHandForAll);

        clownhandforPlayer1 = clownHandForAll;
        clownhandforPlayer2 = clownHandForAll;
        clownhandforPlayer3 = clownHandForAll;
    }







}
