using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseBumper : MonoBehaviour
{
    bool isPaused;
    public GameObject PausePrefab;
    public GameObject MenuButton;

    // Start is called before the first frame update
    void Start()
    {
        PausePrefab.SetActive(false);
        MenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PausePrefab.SetActive(true);
        MenuButton.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        PausePrefab.SetActive(false);
        MenuButton.SetActive(false);
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}