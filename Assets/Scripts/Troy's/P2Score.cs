using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P2Score : MonoBehaviour
{
    public TextMeshProUGUI playerTwo;
    public int player2Score = 0;
    public int targetsHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player2Score = targetsHit * 10;
        playerTwo.text = ("Player 2 Score: " + player2Score.ToString());
    }
}
