using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airBubble : MonoBehaviour
{
    public float BubbleMovement = 0f;
    public float airAmount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BubbleMovement += .005f;

        // move X position based on balloon value
        transform.position = new Vector3(BubbleMovement, transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(" airAmount " + airAmount);
        Destroy(gameObject);
    }


}
