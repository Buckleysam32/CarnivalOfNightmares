using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeCount3 : MonoBehaviour
{
    public TextMeshProUGUI playerThree;
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
            playerThree.text = ("Player 3 Health: " + health.hp.ToString());
        }
        if (health.hp == 1)
        {
            playerThree.text = ("Player 3 Health: " + health.hp.ToString());
        }
        if (health.hp == 0)
        {
            playerThree.text = ("Player 3 Health: " + health.hp.ToString());
        }
    }
}
