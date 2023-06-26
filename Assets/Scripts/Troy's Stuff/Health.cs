using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    public int Lives;
    public int timesdied;
    public Transform Spawn;
    public void Start()
    {
        Lives = 3;
    }

    public void OnCollisionEnter2D(Collision2D Fence)
    {

        {
            if (Fence.gameObject.CompareTag("Fence"))
            {
                
                Lives = 0;
                
            }
        }

        if (Lives <= 0)
        {
            Respawn();
            timesdied = timesdied +1;
            Lives = 1;
        }
    }

    void Respawn()
    {
        transform.position = Spawn.position;
        // Reset any other necessary player state or variables
    }

    private void Update()
    {
        if (timesdied >= 4)
        {
            Destroy(gameObject);
        }
    }

}


    

    

