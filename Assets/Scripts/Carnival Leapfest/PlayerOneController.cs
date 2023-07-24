using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerOneController : MonoBehaviour
{
    public TextMeshProUGUI healthText; // The health counter
    public TextMeshProUGUI scoreText; // The score counter
    public float jumpForce = 6f;  // The force applied to the object when jumping
    private bool isJumping = false;  // Flag to track if the object is currently jumping
    public float health = 3; // The amount of times the player can be hit by the beam
    public float score = 0; // The player's score for the single player mode
    public float scoreIncrease = 100;
    private Rigidbody rb;


    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource hitSoundEffect;

    public Animator myAnim;

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

        if (isJumping == true)
        {
            myAnim.SetBool("isJumping", true);
        }
        if (isJumping == false)
        {
            myAnim.SetBool("isJumping", false);
        }

        healthText.text = "Health: " + health.ToString();
        scoreText.text = "Score: " + (int)score;

        if(health > 0)
        {
            score += scoreIncrease * Time.deltaTime;
            
        }

        if(health <= 0)
        {
            SceneManager.LoadScene("GameOverOneP"); 
        }

        

        PlayerPrefs.SetFloat("score", score);


    }


    private void Jump()
    {
        jumpSoundEffect.Play();
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
            hitSoundEffect.Play();
            health -= 1f;
        }




    }



}
