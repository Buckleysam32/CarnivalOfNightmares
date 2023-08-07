using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("1 Player");
    }

    public void loadTwoPlayer()
    {
        SceneManager.LoadScene("2 Player");
    }

}
