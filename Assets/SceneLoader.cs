using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load360Scene()
    {
        SceneManager.LoadScene("Lab360scene"); // use exact scene name
    }
}

