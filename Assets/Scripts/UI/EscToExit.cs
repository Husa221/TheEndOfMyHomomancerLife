using UnityEngine;
using UnityEngine.SceneManagement;

public class EscToExit : MonoBehaviour
{
    void Update()
    {
        // Kontrola, zda uživatel stiskl klávesu Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu(); // Načte scénu MainMenu
        }
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Nahraď "MainMenu" názvem tvé scény
    }
}
