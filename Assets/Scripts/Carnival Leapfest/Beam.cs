using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{

    public GameObject podium;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Boost"))
        {
            Debug.Log("Speed Increased");
            if(podium.GetComponent<Spin>().rotateSpeed < 200)
            {
                podium.GetComponent<Spin>().rotateSpeed *= 1.2f;
            }
            

        }

        if (collision.gameObject.CompareTag("Boost"))
        {

        }
    }
}
