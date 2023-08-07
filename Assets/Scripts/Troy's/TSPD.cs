using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TSPD : MonoBehaviour
{
    // Start is called before the first frame update

    public float spawnTimer = 0f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public GameObject decoy;
    public int iPickle = 0;
    


    public List<Transform> targetSpawnPoints = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        targetSpawnPoints.Add(spawn1);
        targetSpawnPoints.Add(spawn2);
        targetSpawnPoints.Add(spawn3);
        targetSpawnPoints.Add(spawn4);
        spawnTimer = 5f;
     
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = Random.Range(9, 13);
        }
        
    }
    public void Spawn()
    {
        
        for (iPickle = 0; iPickle <= 3; iPickle++)
        {
            //Instantiate(target, new Vector2(x, y), Quaternion.identity);
            Transform spawnPoint = targetSpawnPoints[Random.Range(0, targetSpawnPoints.Count)];
            GameObject target1 = Instantiate(decoy, spawnPoint.position, spawnPoint.rotation);
        }

    }
}
