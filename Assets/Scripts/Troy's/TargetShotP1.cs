using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShotP1 : MonoBehaviour
{
    public P1Shoot p1shoot;
    public P1Score p1score;
    public GameObject Player1;
    // Start is called before the first frame update
    void Start()
    {
        p1score = GameObject.Find("Player 1").GetComponent<P1Score>();
        p1shoot = GameObject.Find("Player 1").GetComponent<P1Shoot>();
        Player1 = GameObject.Find("Player1").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collider)
    {

        {
            if (p1shoot.p1isshooting == true && collider.gameObject.name == "Player 1")
            {
                Destroy(gameObject);
                p1score.targetsHit = p1score.targetsHit + 1;
            }
        }


    }
}
