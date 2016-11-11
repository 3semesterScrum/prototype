using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ButtonPush : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private Image buttonImg;
    // Use this for initialization
    void Start()
    {
        buttonImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(buttonImg.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
        {
            buttonImg.color = Color.red;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (buttonImg.color == Color.red)
        {
            buttonImg.color = Color.white;
        }
    }
}
