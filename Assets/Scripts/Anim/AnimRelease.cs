using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimRelease : MonoBehaviour
{
    PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = FindAnyObjectByType<PlayerMovement>();
    }

    public void ReleaseFromChanting()
    {
        playerMovement.isDoingMagic = false;
    }
    public void Endgame()
    {
        SceneManager.LoadScene("ScoreBoard");
    }
}
