using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Shoot : MonoBehaviour
{
    public bool p1isshooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            p1isshooting = true;
        }
        else
        {
            p1isshooting = false;
        }
    }
}
