using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static DontDestroyOnLoad instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // zachov�me mezi sc�nami
        }
        else
        {
            Destroy(gameObject); // pokud u� instance existuje, zni��me duplicitu
        }
    }
}
