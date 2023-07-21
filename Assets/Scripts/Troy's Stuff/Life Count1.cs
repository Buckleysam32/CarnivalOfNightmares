using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LifeCount1 : MonoBehaviour
{
    public TextMeshProUGUI playerOne;
    public Health health;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health.hp == 2)
        {
            playerOne.text = ("Player 1 Health: " + health.hp.ToString());
        }
        if (health.hp == 1)
        {
            playerOne.text = ("Player 1 Health: " + health.hp.ToString());
        }
        if (health.hp == 0)
        {
            playerOne.text = ("Player 1 Health: " + health.hp.ToString());
        }
    }
}
