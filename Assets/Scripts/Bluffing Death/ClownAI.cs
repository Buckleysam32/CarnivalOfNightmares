using System.Collections;
using System.Collections.Generic;
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
    public bool playerbluffRound = true;
    public int clownhandforPlayer1 = 0;
    public int clownhandforPlayer2 = 0;
    public int clownhandforPlayer3 = 0;
    public int player1successfulbluff = 0;
    public int player2successfulbluff = 0;
    public int player3successfulbluff = 0;




    //Rock = 0
    //Paper = 1
    //Scissors = 2


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()// look at this link https://youtu.be/sw7UAZNgGg8
    {
        // do a for loop for each players input and do the math

        if (playerbluffRound == true)// when the clown get there first bluff they will aim for a draw this is make it easy for the next round to be prodiced baced off the results
        {
            if (player1 != null)
            {
                //do math with them
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

                //add in a for loop where player1successfulbluff + 1 to the code untill there is non left

                if (clownhandforPlayer1 > 2)
                {
                    clownhandforPlayer1 = 0;
                }
                //end the loop here
            }
            if (player2 != null)
            {
                //do math with them
            }
            if (player3 != null)
            {
                //do math with them
            }
        }
        else
        {

        }


        //after doing the math make a choise

    }
}
