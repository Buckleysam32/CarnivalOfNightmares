using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public float score;

    public void LoadGameOne()
    {
        SceneManager.LoadScene("Carnival Leapfest");
    }

    public void LoadGameTwo()
    {
        SceneManager.LoadScene(5);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        score = PlayerPrefs.GetFloat("score");
        scoreDisplay.text = "Total Score: " + (int)score;
    }

}
