using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coockie1;
    private float initDeltaSpawn = 0.6F;
    public float deltaSpawn = 0.6F;

    public void Start()
    {
        StartCoroutine(CustomUpdate());
        StartCoroutine(SessionTimer());
    }

    public void StartSpawn()
    {
        Instantiate(coockie1 , new Vector2(Random.Range(-1.72F, 1.72F),Random.Range(-4.15F, 4.15F)),Quaternion.identity) ;
        GameManager.Instanse.AmountObjectInScene++;
    }
    public IEnumerator CustomUpdate()
    {
        while (true)
        {
            yield return new WaitForSeconds(deltaSpawn);
            StartSpawn();
        }
    }

    private IEnumerator SessionTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0F);
            GameManager.Instanse.timerCount++;


            if (deltaSpawn > 0.1) deltaSpawn = initDeltaSpawn - CalculateTime();
        }
    }

    /// <summary>
    /// –еагирует на врем€ игрвой сессии измен€€ период спавна
    /// </summary>
    private float CalculateTime()
    {
        float reductionCoefficientTime = GameManager.Instanse.timerCount / 5;
        Mathf.Floor(reductionCoefficientTime);

        float result = GameManager.Instanse.deltaSpawnPeriod * reductionCoefficientTime;
        return result;
    }
}
