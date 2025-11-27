using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToGNG : MonoBehaviour
{
    // Call this from your "Return Previous" button in Lab360Scene
    public void GoToGNGScene()
    {
        // Make sure the scene name matches exactly, including spaces and dashes
        SceneManager.LoadScene("GNG 1103 - Project");
    }
}