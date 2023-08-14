using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class WinP2 : MonoBehaviour
{
    public P1Score p1score;
    public GameObject pwin;
    public GameObject p2wint;
    public GameObject p1wint;
    public P2Score p2score;
    public GameObject menu;
    public bool players2 = false;
    // Start is called before the first frame update
    void Start()
    {
        players2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (p1score.player1Score >= 150)
        {
            pwin.SetActive(true);
            p1wint.SetActive(true);
            menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (p2score.player2Score >= 150)
        {
            p2wint.SetActive(true);
            pwin.SetActive(true);
            menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
