using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    public int Lives;
    public int timesdied;
    public Transform Spawn;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;

    public List<Transform> playerSpawnPoints = new List<Transform>();

    

    public void Start()
    {
        Lives = 3;
        playerSpawnPoints.Add(Spawn);
        playerSpawnPoints.Add(Spawn2);
        playerSpawnPoints.Add(Spawn3);
        playerSpawnPoints.Add(Spawn4);
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
        
        transform.position = playerSpawnPoints[Random.Range(0, playerSpawnPoints.Count)].position;
        
    }



    private void Update()
    {
        if (timesdied >= 4)
        {
            Destroy(gameObject);
        }
    }

}


    

    

