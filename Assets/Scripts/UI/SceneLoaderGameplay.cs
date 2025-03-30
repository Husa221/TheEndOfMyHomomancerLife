using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderGameplay : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("GameplayScene"); // Nahraď názvem tvé scény
    }
}
