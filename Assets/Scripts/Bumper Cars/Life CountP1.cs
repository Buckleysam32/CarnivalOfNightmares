using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LifeCountP1 : MonoBehaviour
{
    public TextMeshProUGUI playerOnep1;
    public Healthp1 healthp1;
    


    // Update is called once per frame
    void Update()
    {
        if (healthp1.hp == 2)
        {
            playerOnep1.text = ("Player 1 Health: " + healthp1.hp.ToString());
        }
        if (healthp1.hp == 1)
        {
            playerOnep1.text = ("Player 1 Health: " + healthp1.hp.ToString());
        }
        if (healthp1.hp == 0)
        {
            playerOnep1.text = ("Player 1 Health: " + healthp1.hp.ToString());
        }
    }
        
}
