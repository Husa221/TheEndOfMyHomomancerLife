using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderStoryScreen : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("StoryScreen"); // Nahraď názvem tvé scény
    }
}
