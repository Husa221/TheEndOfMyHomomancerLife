using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public float delayBeforeLoad = 2f; // Nastavitelná doba zpoždění v sekundách

    private void Update()
    {
        if (NPCCounter.npcCounter == 1)
        {
            StartCoroutine(LoadGameplaySceneWithDelay());
            NPCCounter.npcCounter = 0; // Reset npcCounter, aby se scéna nenačítala znovu
        }
    }

    private IEnumerator LoadGameplaySceneWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeLoad);
        SceneManager.LoadScene("GameplayScene");
    }
}
