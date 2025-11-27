using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel; // assign MenuPanel in inspector

    private bool menuOpen = false;

    public void ToggleMenu()
    {
        menuOpen = !menuOpen;
        menuPanel.SetActive(menuOpen);
    }

    public void CloseMenu()
    {
        menuOpen = false;
        menuPanel.SetActive(false);
    }
}
