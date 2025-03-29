using System.Collections;
using UnityEngine;
using TMPro;

public class FinalVerdict : MonoBehaviour
{
    public TextMeshProUGUI verdictText;  // TextMeshPro object to display the verdict
    public float delay = 3f;  // Delay before displaying the verdict

    private void Start()
    {
        // Start the verdict display after delay
        StartCoroutine(DisplayVerdict());
    }

    private IEnumerator DisplayVerdict()
    {
        yield return new WaitForSeconds(delay);  // Wait for the set delay

        // Calculate how much NPC count remains in percentage
        float npcCount = NPCCounter.npcCounter;
        float countPercentage = (npcCount / NPCCounter.allNpc) * 100f - 100f;  // Subtract 100 to get wasted percentage
        countPercentage = Mathf.Abs(countPercentage);  // Ensure positive value

        // Determine the final verdict
        if (countPercentage == 0)
        {
            verdictText.text = "You were a good hemomancer";
        }
        else if (countPercentage <= 15)
        {
            verdictText.text = "Almost in hemomancer heaven (or hell?)";
        }
        else if (countPercentage <= 40)
        {
            verdictText.text = "You almost redeemed yourself";
        }
        else if (countPercentage <= 60)
        {
            verdictText.text = "You are not enough";
        }
        else if (countPercentage <= 80)
        {
            verdictText.text = "It was your last chance to help.";
        }
        else
        {
            verdictText.text = "You don't know how to play, do you?";
        }
    }
}
