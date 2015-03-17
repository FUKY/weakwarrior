using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class GUITabInput : MonoBehaviour, IPointerDownHandler {

    public GameObject notifycation;
    public void OnPointerDown(PointerEventData eventData)
    {
        notifycation.SetActive(false);
    }
}
