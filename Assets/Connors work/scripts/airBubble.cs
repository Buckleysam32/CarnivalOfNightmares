using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airBubble : MonoBehaviour
{
    public float BubbleMovement = 0f;
    public float airAmount = 0f;

    // Update is called once per frame
    void Update()
    {
        // the air bubble movement over time
        BubbleMovement += .005f;

        // move X position based on balloon value
        transform.position = new Vector3(BubbleMovement, transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when the air bubble reachs the end it will despawn
        Destroy(gameObject);
    }


}
