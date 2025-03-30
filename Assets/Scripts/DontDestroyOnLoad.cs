using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static DontDestroyOnLoad instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // zachováme mezi scénami
        }
        else
        {
            Destroy(gameObject); // pokud už instance existuje, znièíme duplicitu
        }
    }
}
