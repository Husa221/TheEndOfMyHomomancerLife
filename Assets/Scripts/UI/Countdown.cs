using System.Collections;  // Added for IEnumerator
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;  // TextMeshPro object to display the sentence
    public float duration = 5f;  // Time duration over which the countdown should occur (in seconds)
    private float npcCount = NPCCounter.npcCounter;  // Get NPC count from NPCCounter
    public float countPercentage = 0f;  // Percentage of remaining NPCs

    private void Start()
    {
        // Calculate how much NPC count remains in percentage
        countPercentage = Mathf.Round((npcCount / NPCCounter.allNpc) * 100f - 100f);  // Round to whole number

        // Starts the countdown coroutine
        StartCoroutine(CountDownFrom100());
    }

    private IEnumerator CountDownFrom100()
    {
        float currentTime = 99f;  // Start from 99%
        float step = Mathf.Round((100f - Mathf.Abs(countPercentage)) / duration);  // Ensure step is a whole number

        while (currentTime > Mathf.Abs(countPercentage))
        {
            currentTime -= step * Time.deltaTime;  // Decrease the value over time
            int percentage = Mathf.RoundToInt(currentTime);  // Convert to whole number

            // Update the TextMeshPro text with the sentence
            countdownText.text = $"You wasted {percentage}% of your blood!";

            // Wait for the next frame
            yield return null;
        }

        // Ensure the text shows the exact target value when done
        countdownText.text = $"You wasted {Mathf.RoundToInt(Mathf.Abs(countPercentage))}% of your blood!";
    }
}
