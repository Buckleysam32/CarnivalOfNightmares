using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Healthp1 : MonoBehaviour
{
    
    public bool alive = true;
    public int timesdied;
    public Transform Spawn;
    

    public List<Transform> playerSpawnPoints = new List<Transform>();

    

    public void Start()
    {
        
        playerSpawnPoints.Add(Spawn);
        
    }

    public void OnCollisionEnter2D(Collision2D Fence)
    {
        if (Fence.gameObject.CompareTag("Fence"))
        {

            alive = false;

        }
    }

    void Respawn()
    {
        
        transform.position = playerSpawnPoints[Random.Range(0, playerSpawnPoints.Count)].position;
        
    }



    private void Update()
    {
        if (timesdied >= 4)
        {
            transform.position = new Vector3(10000f, 10000f, 0f);
        }
        if (alive == false)
        {
            Respawn();
            timesdied = timesdied + 1;
            alive = true;
        }
    }

}


    

    

