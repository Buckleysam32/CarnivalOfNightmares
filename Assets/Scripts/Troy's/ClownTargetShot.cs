using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownTargetShot : MonoBehaviour
{
    public P1Shoot p1shoot;
    public P1Score p1score;
    public P2Shoot p2shoot;
    public P2Score p2score;
    public P3Shoot p3shoot;
    public P3Score p3score;
    public GameObject Player1;
    public TSPD tspd;
    public Animator clownAnim;
    // Start is called before the first frame update
    void Start()
    {
        p1score = GameObject.Find("Player 1").GetComponent<P1Score>();
        p2score = GameObject.Find("Player 2").GetComponent<P2Score>();
        p3score = GameObject.Find("Player 3").GetComponent<P3Score>();
        p1shoot = GameObject.Find("Player 1").GetComponent<P1Shoot>();
        p2shoot = GameObject.Find("Player 2").GetComponent<P2Shoot>();
        p3shoot = GameObject.Find("Player 3").GetComponent<P3Shoot>();
        Player1 = GameObject.Find("Player1").GetComponent<GameObject>();
        clownAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {

        {
            if (p1shoot.p1isshooting == true && collision.gameObject.name == "Player 1")
            {
                clownAnim.SetBool("IsShot", true);
                p1score.targetsHit = p1score.targetsHit - 10;
                
                Destroy(this.gameObject, 2f);
                clownAnim.Play("clownAnim");
                
            }
            if (p2shoot.p2isshooting == true && collision.gameObject.name == "Player 2")
            {

                p2score.targetsHit = p2score.targetsHit - 10;
                clownAnim.SetBool("IsShot", true);
                Destroy(this.gameObject, 2f);
                clownAnim.Play("clownAnim");
            }
            if (p3shoot.p3isshooting == true && collision.gameObject.name == "Player 3")
            {
                p3score.targetsHit = p3score.targetsHit - 10;
                clownAnim.SetBool("IsShot", true);
                Destroy(this.gameObject, 2f);
                clownAnim.Play("clownAnim");
            }
        }


    }
}