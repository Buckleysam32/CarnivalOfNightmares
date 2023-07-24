using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public float spawnTimer1 = 0f;
    public float spawnTimer2 = 0f;
    public float spawnTimer3 = 0f;
    public float spawnTimer4 = 0f;
    public float spawnTimer5 = 0f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;
    public Transform spawn7;
    public Transform spawn8;


    public List<Transform> targetSpawnPoints = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        targetSpawnPoints.Add(spawn1);
        targetSpawnPoints.Add(spawn2);
        targetSpawnPoints.Add(spawn3);
        targetSpawnPoints.Add(spawn4);
        targetSpawnPoints.Add(spawn5);
        targetSpawnPoints.Add(spawn6);
        targetSpawnPoints.Add(spawn7);
        targetSpawnPoints.Add(spawn8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
