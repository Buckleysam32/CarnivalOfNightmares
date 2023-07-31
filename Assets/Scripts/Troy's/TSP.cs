using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TSP : MonoBehaviour
{
    // Start is called before the first frame update

    public float spawnTimer = 0f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;
    public Transform spawn7;
    public Transform spawn8;
    public GameObject target;
    public int iPickle = 0;


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
        spawnTimer = 5f;
     
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = 10f;
        }
    }
    public void Spawn()
    {

        for (iPickle = 0; iPickle <= 4; iPickle++)
        {
            //Instantiate(target, new Vector2(x, y), Quaternion.identity);
            Transform spawnPoint = targetSpawnPoints[Random.Range(0, targetSpawnPoints.Count)];
            GameObject target1 = Instantiate(target, spawnPoint.position, spawnPoint.rotation);
        }

    }
}
