using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public TSP tsp;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public bool v1 = false;
    public bool v2 = false;
    public bool v3 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player 1")
        {
            player1.transform.position = tsp.spawn9.position;
            v1 = true;
            
        }
        if (collider.gameObject.name == "Player 2")
        {
            player2.transform.position = tsp.spawn9.position;
            v2 = true;
        }
        if (collider.gameObject.name == "Player 3")
        {
            player3.transform.position = tsp.spawn9.position;
            v3 = true;
        }
    }
}
