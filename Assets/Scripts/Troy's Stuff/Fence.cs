using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Fence : MonoBehaviour
{
    public Health health;
    public bool eletrified = false;
    public float timer;
    public float timerEl;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(5, 15);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 0;
        }
        if (timerEl < 0)
        {
            timerEl = 0;
        }
        if (timer <= 0 && eletrified == false)
        {
            eletrified= true;
            timerEl = 7f;
        }

        if (eletrified == true)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 1);
            timerEl -= Time.deltaTime;
            timer = Random.Range(5, 15);
            
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1);
        }


        if (timerEl<= 0)
        {
            eletrified= false;
            

        }

    }

    public void OnCollisionEnter2D(Collision2D Player)
    {

        {
            if (eletrified == true)
            {

                Player.gameObject.GetComponent<Health>().alive= false;

            }
            else
            {

            }

        }


    }

}
