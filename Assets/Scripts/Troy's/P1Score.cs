using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P1Score : MonoBehaviour
{
    public TextMeshProUGUI playerOne;
    public int player1Score = 0;
    public int targetsHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Score = targetsHit * 10;
        playerOne.text = ("Player 1 Score: " + player1Score.ToString());
    }
}
