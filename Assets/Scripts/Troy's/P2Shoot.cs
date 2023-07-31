using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Shoot : MonoBehaviour
{
    public bool p2isshooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            p2isshooting = true;
        }
        else
        {
            p2isshooting = false;
        }
    }
}
