using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableLinks : MonoBehaviour, IPointerClickHandler
{
    public string linkURL;

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(linkURL);
    }
}
