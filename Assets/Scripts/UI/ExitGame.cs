using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Tato metoda ukončí hru
    public void QuitGame()
    {
        // Pokud hra běží v editoru, zastaví se (editor nebude ukončen, ale hra se zastaví)
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();  // Ukončí hru v buildu
#endif
    }
}
