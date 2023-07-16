using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Fence : MonoBehaviour
{
    public Health health;
    public GameObject eel;
    public bool eletrified = false;
    public float timer;
    public float timerEl;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(5, 15);
        eel.SetActive(false);
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
            timerEl -= Time.deltaTime;
            eel.SetActive(true);
            timer = Random.Range(5, 15);
        }

        if (timerEl<= 0)
        {
            eletrified= false;
            eel.SetActive(false);
            
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
