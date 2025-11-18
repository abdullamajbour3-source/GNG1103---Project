using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject popupPanel;

    public void ShowPopup()
    {
        if (popupPanel != null)
            popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        if (popupPanel != null)
            popupPanel.SetActive(false);
    }
}
