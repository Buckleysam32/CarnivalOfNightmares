using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class WinP1 : MonoBehaviour
{
    public P1Score p1score;
    public GameObject pwin;
    public GameObject plose;
    public GameObject p1wint;
    public GameObject p1losst;
    public TextMeshProUGUI time;
    
    public float timer = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        time.text = ("Time: " + timer.ToString());
        if (p1score.player1Score >= 200)
        {
            pwin.SetActive(true);
            p1wint.SetActive(true);
            Time.timeScale = 0;
        }
        if (timer <= 0)
        {
            plose.SetActive(true);
            p1losst.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
