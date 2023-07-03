using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator myAnim;

    private void Start()
    {
        myAnim = GetComponent<Animator>();
    }


    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetAxisRaw("Horizontal") == 0.1 || Input.GetAxisRaw("Horizontal") == -0.1 || Input.GetAxisRaw("Vertical") == 0.1 || Input.GetAxisRaw("Vertical") == -0.1)
        {
            myAnim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        }

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
