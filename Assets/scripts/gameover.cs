using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameoverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void RestartGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       gameObject.SetActive(false);
       Time.timeScale = 1f;
    }
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}