using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{

    public GameObject lossback;
    public GameObject losstext;
    public Healthp1 health1;
    public AudioSource losssound;

    // Start is called before the first frame update
    void Start()
    {
        lossback.SetActive(false);
        losstext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health1.timesdied >= 3)
        {
            losssound.Play();
            Time.timeScale = 0;
            losstext.SetActive(true);
            lossback.SetActive(true);
        }
    }
}
