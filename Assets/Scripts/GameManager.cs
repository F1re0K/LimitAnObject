using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instanse;

    public GameManager()
    {
        Instanse = this;
    }

    public GameObject textScoreUI;
    private int score = 0;
    public int timerCount = 0;
    public float deltaSpawnPeriod = 0.1F;

    [SerializeField] private int amountObjectInScene = 0;

    public int AmountObjectInScene
    {
        get => amountObjectInScene;
        set
        {
            if (value < 0)
            {
                amountObjectInScene = 0;
                Debug.LogError("Кол-во объектов на сцене попыталось быть меньше нуля");
            }
            else
            {
                amountObjectInScene = value;
            }

            if (amountObjectInScene >= 15)
            {
                GameOver.Instanse.ShowGameOver();
            }
        }
    }

    public int Score 
    {
        get => score;
        set
        {
            if (value < 0)
            {
                score = 0;
            }
            else
            {
                score = value;
            }
            textScoreUI.GetComponent<Text>().text = score.ToString();
        }
    }

    
}
