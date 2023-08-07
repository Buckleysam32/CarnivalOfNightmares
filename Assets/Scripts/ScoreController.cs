using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI winnerText;
    private float currentTime;





    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0f;
        TimerDisplayUpdate();
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        TimerDisplayUpdate();

    }

    private void TimerDisplayUpdate()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        winnerText.text = "You Lasted: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
