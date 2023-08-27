using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;

public class mainmenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("123");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
