using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementS3 : MonoBehaviour
{
    public float moveSpeed = -10f;

    public Rigidbody2D rb;

    Vector2 movement;

    

    private void Start()
    {
        
    }


    private void Update()
    {

        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector2.right);
        }

        if (Input.GetKey(KeyCode.G))
        {
            rb.AddForce(Vector2.left);
        }

        if (Input.GetKey(KeyCode.H))
        {
            rb.AddForce(Vector2.down);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            rb.AddForce(Vector2.up);
        }
        if (rb.velocity.magnitude > 7f)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, 7f);
        }
    }
}
