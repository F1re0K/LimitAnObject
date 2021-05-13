using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public static GameOver Instanse;
    public GameObject gameOverDisplay;

    public GameOver()
    {
        Instanse = this;
    }

    public void ShowGameOver()
    {
        gameOverDisplay.SetActive(true);
        Time.timeScale = 0;
        GameManager.Instanse.TouchDetectActive = false;
    }

    public void GameOverNow()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
