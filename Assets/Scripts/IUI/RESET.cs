using UnityEngine;

public class RESET : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NPCCounter.npcCounter = 0;
        Debug.Log("Kravicekzachraneno:" + NPCCounter.npcCounter);
    }

    
}
