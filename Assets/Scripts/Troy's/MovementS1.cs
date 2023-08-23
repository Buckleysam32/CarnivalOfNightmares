using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementS1 : MonoBehaviour
{
    public float moveSpeed = -10f;

    public Rigidbody2D rb;




    private void Start()
    {
        
    }


    private void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up);
        }


        if (rb.velocity.magnitude > 7f)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, 7f);
        }
    }
}
