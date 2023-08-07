using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float pushForce = 5f;

    public float pushDuration = 0.2f;

    private bool isPushing = true;

    private void Start()
    {
        int enemyLayer = gameObject.layer;
        int ignoreLayer = LayerMask.NameToLayer("EnemyIgnoreLayer");
        Physics2D.IgnoreLayerCollision(enemyLayer, ignoreLayer, true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
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

    void StopPush()
    {
        isPushing = false;
    }
}
