using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LifeCount2 : MonoBehaviour
{
    public TextMeshProUGUI playerTwo;
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
            playerTwo.text = ("Player 2 Health: " + health.hp.ToString());
        }
        if (health.hp == 1)
        {
            playerTwo.text = ("Player 2 Health: " + health.hp.ToString());
        }
        if (health.hp == 0)
        {
            playerTwo.text = ("Player 2 Health: " + health.hp.ToString());
        }
    }
}
