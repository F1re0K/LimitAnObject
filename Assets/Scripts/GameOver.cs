using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
    }

    public void GameOverNow()
    {

    }
}
