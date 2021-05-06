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
    private int amountObjectInScene = 0;
    public int timerCount = 0;
    public float deltaSpawnPeriod = 0.15F;

    public int AmountObjectInScene 
    {
        get => amountObjectInScene;
        set
        {
            if (value < 0)
            {
                amountObjectInScene = 0;
            }
            else
            {
                amountObjectInScene = value;
            }
            textScoreUI.GetComponent<Text>().text = amountObjectInScene.ToString();
        }
    }

    
}
