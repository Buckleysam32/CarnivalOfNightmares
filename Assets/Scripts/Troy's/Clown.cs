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
    
    public int clowns = 1;
    public TSP tsp;
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
        if (tsp.targetsspawned >= 10 && clowns == 1)
        {
            
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 30 && clowns == 2)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 50 && clowns == 3)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 60 && clowns == 4)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 80 && clowns == 5)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 100 && clowns == 6)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 120 && clowns == 7)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 140 && clowns == 8)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
        if (tsp.targetsspawned >= 180 && clowns == 9)
        {
            Transform spawnPoint = clownSpawnPoints[Random.Range(0, clownSpawnPoints.Count)];
            GameObject target1 = Instantiate(clown, spawnPoint.position, spawnPoint.rotation);
            clowns = clowns + 1;
        }
    }
}
