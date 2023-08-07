using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TargetLife : MonoBehaviour
{
    public float lifeTimer = 6f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer -= Time.deltaTime;
        
        if (lifeTimer <= 0)
        {
            Destroy(gameObject);
            lifeTimer = 6f;
        }
    }
}
