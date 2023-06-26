using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Fence : MonoBehaviour
{
    public bool fence1 = false;
    public bool fence2 = false;
    public bool fence3 = false;
    public bool fence4 = false;
    public int fence;
    public int fencetwo;
    public int timer;
    public int fentimer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 1)
        {
            timer = timer - 1;
        }
        else
        {
            fence = Random.Range(1, 4);
            fencetwo = Random.Range(1, 4);
            if (fence == 1)
            {
                fence1 = true;
            }
            if (fence == 2)
            {
                fence2 = true;
            }
            if (fence == 3)
            {
                fence3 = true;
            }
            if (fence == 4)
            {
                fence4 = true;
            }
        }
        
    }
}
