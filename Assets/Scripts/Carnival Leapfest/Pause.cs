using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    bool isPaused;
    public GameObject PausePrefab;
    public GameObject menuButton;

    // Start is called before the first frame update
    void Start()
    {
        PausePrefab.SetActive(false);
        menuButton.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
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
       Time.timeScale = 0;
        isPaused = true;
        PausePrefab.SetActive(true);
        menuButton.SetActive(true);
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        PausePrefab.SetActive(false);
        menuButton.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

}
