using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public static GameOver Instanse;
    public GameObject gameOverDisplay;

    public GameObject resultTextUI;

    public GameOver()
    {
        Instanse = this;
    }

    public void ShowGameOver()
    {
        SetBestScore(GameManager.Instanse.Score);

        resultTextUI.GetComponent<Text>().text = "—чет: " + GameManager.Instanse.Score + "\r\n" + "–екорд: " + GetBestScore().ToString();                                                                                                                                                                                                             


        gameOverDisplay.SetActive(true);
        Time.timeScale = 0;
        GameManager.Instanse.TouchDetectActive = false;
    }

    public void GameOverNow()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore");
    }

    public void SetBestScore(int score)
    {
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
}
