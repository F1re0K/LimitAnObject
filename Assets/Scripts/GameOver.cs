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
    }

    public void GameOverNow()
    {
        Debug.Log("Работвает");
        SceneManager.LoadScene("SampleScene");
    }
}
