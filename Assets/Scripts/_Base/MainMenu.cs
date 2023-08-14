using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void toMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Game()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void Player1()
    {
        SceneManager.LoadScene("ShooterP1");
    }
    public void Player2()
    {
        SceneManager.LoadScene("ShooterP2");
    }
    public void Player3()
    {
        SceneManager.LoadScene("ShooterP3");
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
