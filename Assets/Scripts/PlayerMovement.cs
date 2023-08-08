using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator myAnimator;

    public float moveSpeed = 5f; // The speed of the player's movement

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // These will store the playermovement on both axis
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Move player up when W is pressed
        if (gameObject.tag == "PlayerOne")
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveVertical = 1f;
            }
            // Move player down when S is pressed
            if (Input.GetKey(KeyCode.S))
            {
                moveVertical = -1f;
            }
            // Move player left when A is pressed
            if (Input.GetKey(KeyCode.A))
            {
                moveHorizontal = -1f;
            }
            // Move player right when D is pressed
            if (Input.GetKey(KeyCode.D))
            {
                moveHorizontal = 1f;
            }
        }

        if (gameObject.tag == "PlayerTwo")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveVertical = 1f;
            }
            // Move player down when S is pressed
            if (Input.GetKey(KeyCode.DownArrow))
            {
                moveVertical = -1f;
            }
            // Move player left when A is pressed
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveHorizontal = -1f;
            }
            // Move player right when D is pressed
            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveHorizontal = 1f;
            }
        }

        //Animation
        if (moveHorizontal != 0f) // Check if the player is moving horizontally (left or right)
        {
            myAnimator.SetBool("IsWalking", true);
            myAnimator.SetBool("IsFacingRight", moveHorizontal > 0f); // Set "IsFacingRight" to true if moving right, false otherwise
        }
        else
        {
            myAnimator.SetBool("IsWalking", false);
        }


        //Calculate the movement direction
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;

        //Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);



    }
}
