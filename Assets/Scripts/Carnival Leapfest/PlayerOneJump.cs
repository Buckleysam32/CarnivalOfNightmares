using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneJump : MonoBehaviour
{
    public float jumpForce = 5f;  // The force applied to the object when jumping
    private bool isJumping = false;  // Flag to track if the object is currently jumping

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(new Vector3(0f, jumpForce), ForceMode.Impulse);
        isJumping = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object has landed on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }



}
