using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void toMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale= 1f;
    }
    public void Game()
    {
        SceneManager.LoadScene("GameMenu");
        Time.timeScale = 1f;
    }
    public void Player1()
    {
        SceneManager.LoadScene("ShooterP1");
        Time.timeScale = 1f;
        
    }
    public void Player2()
    {
        SceneManager.LoadScene("ShooterP2");
        Time.timeScale = 1f;
    }
    public void Player3()
    {
        SceneManager.LoadScene("ShooterP3");
        Time.timeScale = 1f;
    }

    public void Options()
    {
        Debug.Log("no options implemented yet");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
