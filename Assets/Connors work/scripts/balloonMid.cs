using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonMid : MonoBehaviour
{
    public GameObject balloonEnd;
    public float X;

    // Update is called once per frame
    void Update()
    {
        //Transform balloonEnd = GetComponent<Transform>();
        X = balloonEnd.transform.position.x / 2f;

        transform.position = new Vector3(X, transform.position.y, transform.position.z);

        X = X / 2f;
        transform.localScale = new Vector3(X, 1, 1);
    }
}
