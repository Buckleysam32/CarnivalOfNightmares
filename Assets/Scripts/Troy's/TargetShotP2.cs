using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShotP2 : MonoBehaviour
{
    public P1Shoot p1shoot;
    public P1Score p1score;
    public P2Shoot p2shoot;
    public P2Score p2score;
    public GameObject Player1;
    public AudioSource targetnoise;

    // Start is called before the first frame update
    void Start()
    {
        p1score = GameObject.Find("Player 1").GetComponent<P1Score>();
        p2score = GameObject.Find("Player 2").GetComponent<P2Score>();
        p1shoot = GameObject.Find("Player 1").GetComponent<P1Shoot>();
        p2shoot = GameObject.Find("Player 2").GetComponent<P2Shoot>();
        Player1 = GameObject.Find("Player1").GetComponent<GameObject>();
        targetnoise = GetComponent<AudioSource>();
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
                targetnoise.Play();
                Destroy(gameObject);
                p1score.targetsHit = p1score.targetsHit + 1;
            }
            if (p2shoot.p2isshooting == true && collider.gameObject.name == "Player 2")
            {
                targetnoise.Play();
                Destroy(gameObject);
                p2score.targetsHit = p2score.targetsHit + 1;
            }
        }


    }
}
