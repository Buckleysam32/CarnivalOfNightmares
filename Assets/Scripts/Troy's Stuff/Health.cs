using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    
    public bool alive = true;
    public int timesdied;
    public Transform Spawn;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;
    public AudioSource Died;

    public List<Transform> playerSpawnPoints = new List<Transform>();

    

    public void Start()
    {
        
        playerSpawnPoints.Add(Spawn);
        playerSpawnPoints.Add(Spawn2);
        playerSpawnPoints.Add(Spawn3);
        playerSpawnPoints.Add(Spawn4);
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
            Died.Play();
            timesdied = timesdied + 1;
            alive = true;
        }
    }

}


    

    

