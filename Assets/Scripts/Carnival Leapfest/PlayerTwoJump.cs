using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerTwoJump : MonoBehaviour
{
    public TextMeshProUGUI healthText; // The health counter

    public float jumpForce = 5f;  // The force applied to the object when jumping
    private bool isJumping = false;  // Flag to track if the object is currently jumping
    private float beamForce = 50f; // The force applied to the object when colliding with the beam
    public float health = 3; // The amount of times the player can be hit by the beam

    private Rigidbody rb;

    public Animator myAnim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !isJumping)
        {
            Jump();
        }

        if (isJumping == true)
        {
            myAnim.SetBool("isJumping", true);
        }
        if (isJumping == false)
        {
            myAnim.SetBool("isJumping", false);
        }

        healthText.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOverOne");
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

        // Take health from the player when they collide with the beam
        if (collision.gameObject.CompareTag("Beam"))
        {
            health -= 1f;
        }

        /*if (collision.gameObject.CompareTag("Beam"))
        {
            rb.AddForce(new Vector3(beamForce, 0f), ForceMode.Impulse);
        }*/
    }



}
