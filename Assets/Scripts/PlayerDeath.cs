using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject gameOverPrefab;

    public TextMeshProUGUI winnerDisplay;


    private void Start()
    {
        gameOverPrefab.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        
        if (other.CompareTag("DeathCollider"))
        {
            // Handle player death here (e.g., play death animation, reset game, etc.)
            PlayerDied();

            if (gameObject.tag == "PlayerOne")
            {
                winnerDisplay.text = "Player Two Wins";
            }

            if (gameObject.tag == "PlayerTwo")
            {
                winnerDisplay.text = "Player One Wins";
            }
        }



    }

    private void PlayerDied()
    {
        Debug.Log("Player has died.");
        gameOverPrefab.SetActive(true);
        Time.timeScale = 0;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("PP Main Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("2 Player");
    }
    public void RestartGameOneP()
    {
        SceneManager.LoadScene("1 Player");
    }

}
