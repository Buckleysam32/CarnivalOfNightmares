using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Clown : MonoBehaviour
{
    public GameObject clown;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public TSP tsp;
    public bool clowns = false;
    public List<Transform> clownSpawnPoints = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        clownSpawnPoints.Add(spawn1);
        clownSpawnPoints.Add(spawn2);
        clownSpawnPoints.Add(spawn3);
        clownSpawnPoints.Add(spawn4);
    }

    // Update is called once per frame
    void Update()
    {
        if (tsp.targetsspawned == 10 && clowns == false)
        {
            Spawn();
            clowns = true;
        }
        if (tsp.targetsspawned == 30 && clowns == true)
        {
            Spawn();
            clowns = false;
        }
        if (tsp.targetsspawned == 50 && clowns == false)
        {
            Spawn();
            clowns = true;
        }
        if (tsp.targetsspawned == 60 && clowns == true)
        {
            Spawn();
            clowns = false;
        }
        if (tsp.targetsspawned == 80 && clowns == false)
        {
            Spawn();
            clowns = true;
        }
        if (tsp.targetsspawned == 100 && clowns == true)
        {
            Spawn();
            clowns = false;
        }
        if (tsp.targetsspawned == 120 && clowns == false)
        {
            Spawn();
            clowns = true;
        }
        if (tsp.targetsspawned == 140 && clowns == true)
        {
            Spawn();
            clowns = false;
        }
        if (tsp.targetsspawned == 180 && clowns == false)
        {
            Spawn();
            clowns = true;
        }
    }
    public void Spawn()
    {
        Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
        Transform spawnPoint2 = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
        GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
        GameObject target2 = Instantiate(clown, spawnPoint2.position, spawnPoint2.rotation);



    }
}
