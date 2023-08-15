using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject helpPrefab;

    private void Start()
    {
        helpPrefab.SetActive(false);
    }
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("1 Player");
    }

    public void loadTwoPlayer()
    {
        SceneManager.LoadScene("2 Player");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void helpMenuOpen()
    {
        helpPrefab.SetActive(true);
    }

    public void helpMenuClose()
    {
        helpPrefab.SetActive(false);
    }

}
