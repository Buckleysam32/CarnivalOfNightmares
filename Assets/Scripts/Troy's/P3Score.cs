using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P3Score : MonoBehaviour
{
    public TextMeshProUGUI playerThree;
    public int player3Score = 0;
    public int targetsHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player3Score = targetsHit * 10;
        playerThree.text = ("Player 3 Score: " + player3Score.ToString());
    }
}
