using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    public float jump;

    [SerializeField] private LayerMask jumpableGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
