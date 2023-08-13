using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Shoot : MonoBehaviour
{
    public Walls walls1;
    public Walls walls2;
    public Walls walls3;
    public Walls walls4;
    public Rigidbody2D rb;
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
        if (walls1.v2 == true)
        {
            rb.velocity = Vector2.zero;
            walls1.v2 = false;   
        }
        if (walls2.v2 == true)
        {
            rb.velocity = Vector2.zero;
            walls2.v2 = false;
        }
        if (walls3.v2 == true)
        {
            rb.velocity = Vector2.zero;
            walls3.v2 = false;
        }
        if (walls4.v2 == true)
        {
            rb.velocity = Vector2.zero;
            walls4.v2 = false;
        }
    }
}
