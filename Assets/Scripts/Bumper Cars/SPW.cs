using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SPW : MonoBehaviour
{

    public GameObject greenback;
    public GameObject winner;

    // Start is called before the first frame update
    void Start()
    {
        winner.SetActive(false);
        greenback.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D Win)
    {
        if (Win.gameObject.CompareTag("Win"))
        {

            winner.SetActive(true);
            greenback.SetActive(true);

        }
    }


}
