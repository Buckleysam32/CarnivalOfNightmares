using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class Win : MonoBehaviour
{
    public P1Score p1score;
    public GameObject pwin;
    public GameObject p2win;
    public GameObject p3win;
    public GameObject p1wint;
    public P2Score p2score;
    public P3Score p3score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p1score.player1Score >= 200)
        {
            pwin.SetActive(true);
            p1wint.SetActive(true);
        }
        if (p2score.player2Score >= 200)
        {
            p2win.SetActive(true);
            p1wint.SetActive(true);
        }
        if (p3score.player3Score >= 200)
        {
            p3win.SetActive(true);
            p1wint.SetActive(true);
        }
    }
}
