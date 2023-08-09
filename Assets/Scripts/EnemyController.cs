using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float pushForce = 5f;

    public float pushDuration = 0.2f;

    public float destroyDelay = 1f;

    private bool isPushing = true;

    private Animator enemyAnim;

    private SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;

    private void Start()
    {
        int enemyLayer = gameObject.layer;
        int ignoreLayer = LayerMask.NameToLayer("EnemyIgnoreLayer");
        Physics2D.IgnoreLayerCollision(enemyLayer, ignoreLayer, true);
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        enemyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        AdjustSortingLayer();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isPushing)
        {
            // Calculate the push direction away from the enemy
            Vector3 pushDirection = collision.transform.position - transform.position;
            pushDirection.Normalize();

            // Apply the push effect to the player
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
                isPushing = true;
                Invoke(nameof(StopPush), pushDuration);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyDeath"))
        {
            rb.gravityScale = 1;
            rb.constraints = RigidbodyConstraints2D.None;
            enemyAnim.SetBool("IsDying", true);
            Invoke(nameof(DestroyObject), destroyDelay);
        }
    }

    void DestroyDelayed()
    {
        Destroy(gameObject);
    }

    void StopPush()
    {
        isPushing = false;
    }

    private void AdjustSortingLayer()
    {
        spriteRenderer.sortingOrder = (int)(transform.position.y * -32);
    }
}
