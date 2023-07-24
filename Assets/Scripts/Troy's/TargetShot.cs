using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShot : MonoBehaviour
{
    public P1Shoot p1shoot;
    public P1Score p1score;
    public P2Shoot p2shoot;
    public P2Score p2score;
    public P3Shoot p3shoot;
    public P3Score p3score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collider)
    {

        {
            if (p1shoot.p1isshooting == true)
            {
                Destroy(gameObject);
                p1score.targetsHit = p1score.targetsHit + 1;
            }
            if (p2shoot.p2isshooting == true)
            {
                Destroy(gameObject);
                p2score.targetsHit = p2score.targetsHit + 1;
            }
            if (p3shoot.p3isshooting == true)
            {
                Destroy(gameObject);
                p3score.targetsHit = p3score.targetsHit + 1;
            }
        }


    }
}
