using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchDetect : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.Instanse.Score++;
        GameManager.Instanse.AmountObjectInScene--;
        Destroy(gameObject);
    }
}
