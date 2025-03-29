using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonTMPTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text buttonText;
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;

    void Start()
    {
        buttonText.color = normalColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = normalColor;
    }
}