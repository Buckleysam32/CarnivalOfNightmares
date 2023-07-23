using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WInScript : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player1Win;
    public GameObject Player2Win;
    public GameObject Player3Win;
    public GameObject Tied;
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        Player1Win.SetActive(false); 
        Player2Win.SetActive(false); 
        Player3Win.SetActive(false);
        Tied.SetActive(false);
        back.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.gameObject.GetComponent<Health>().timesdied < 4 && Player2.gameObject.GetComponent<Health>().timesdied >= 4 && Player3.gameObject.GetComponent<Health>().timesdied >= 4)
        {
            back.SetActive(true);
            Player1Win.SetActive(true);
            Time.timeScale= 0f;
        }
        if (Player1.gameObject.GetComponent<Health>().timesdied >= 4 && Player2.gameObject.GetComponent<Health>().timesdied < 4 && Player3.gameObject.GetComponent<Health>().timesdied >= 4)
        {
            back.SetActive(true);
            Player2Win.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Player1.gameObject.GetComponent<Health>().timesdied >= 4 && Player2.gameObject.GetComponent<Health>().timesdied >= 4 && Player3.gameObject.GetComponent<Health>().timesdied < 4)
        {
            back.SetActive(true);
            Player3Win.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Player1.gameObject.GetComponent<Health>().timesdied >= 4 && Player2.gameObject.GetComponent<Health>().timesdied >= 4 && Player3.gameObject.GetComponent<Health>().timesdied >= 4)
        {
            back.SetActive(true);
            Tied.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
