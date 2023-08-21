using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyTargetShotP1 : MonoBehaviour
{
    public P1Shoot p1shoot;
    public P1Score p1score;
    public GameObject Player1;
    public TSPD tspd;
    public Animator targetAnim;
    // Start is called before the first frame update
    void Start()
    {
        p1score = GameObject.Find("Player 1").GetComponent<P1Score>();
        p1shoot = GameObject.Find("Player 1").GetComponent<P1Shoot>();
        Player1 = GameObject.Find("Player1").GetComponent<GameObject>();
        targetAnim = GetComponent<Animator>();

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
                targetAnim.SetBool("IsShot", true);
                p1score.targetsHit = p1score.targetsHit - 1;
                Destroy(gameObject, 5);
                Destroy(this);
            }
        }


    }
}