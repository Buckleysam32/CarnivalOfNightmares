using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Instuctions : MonoBehaviour
{
    public float timer = 50000f;
    public GameObject ints;
    // Start is called before the first frame update
    void Start()
    {
        ints.SetActive(true);
        Time.timeScale = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - 0.01f;
        if (timer <= 0)
        {
            ints.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
