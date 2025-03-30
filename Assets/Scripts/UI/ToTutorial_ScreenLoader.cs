using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTutorial_ScreenLoader: MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("TutorialScreen"); // Nahraď názvem tvé scény
    }
}
