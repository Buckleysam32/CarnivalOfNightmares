using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Shoot : MonoBehaviour
{
    public Walls walls1;
    public Walls walls2;
    public Walls walls3;
    public Walls walls4;
    public Rigidbody2D rb;
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
        if (walls1.v3 == true)
        {
            rb.velocity = Vector2.zero;
            walls1.v3 = false;
        }
        if (walls2.v3 == true)
        {
            rb.velocity = Vector2.zero;
            walls2.v3 = false;
        }
        if (walls3.v3 == true)
        {
            rb.velocity = Vector2.zero;
            walls3.v3 = false;
        }
        if (walls4.v3 == true)
        {
            rb.velocity = Vector2.zero;
            walls4.v3 = false;
        }
    }
}
