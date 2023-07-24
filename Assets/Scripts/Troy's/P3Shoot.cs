using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Shoot : MonoBehaviour
{
    public bool p3isshooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            p3isshooting = true;
        }
        else
        {
            p3isshooting = false;
        }
    }
}
