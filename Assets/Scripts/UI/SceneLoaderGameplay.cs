using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderGameplay : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("TutorialScreen"); // Nahraď názvem tvé scény
    }
}
