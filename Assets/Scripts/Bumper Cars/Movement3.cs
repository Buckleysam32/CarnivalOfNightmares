using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = -10f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator myAnim;

    private void Start()
    {
        myAnim = GetComponent<Animator>();
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

    }
}
