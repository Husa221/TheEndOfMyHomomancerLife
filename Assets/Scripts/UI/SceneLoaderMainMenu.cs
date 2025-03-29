using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderMainMenu : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("MainMenu"); // Nahraď názvem tvé scény
    }
}
