using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeInSequence : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public Button button;

    public float fadeDuration = 1f; // Doba trvani fade efektu
    public float delayText1 = 0f;   // Zpozdeni pro prvni text
    public float delayText2 = 1f;   // Zpozdeni pro druhy text
    public float delayText3 = 2f;   // Zpozdeni pro treti text
    public float delayButton = 2f;  // Tlacitko se objevi zaroven s tretim textem

    private void Start()
    {
        // Skryjeme vsechny objekty na zacatku
        SetAlpha(text1, 0);
        SetAlpha(text2, 0);
        SetAlpha(text3, 0);
        SetAlpha(button.image, 0); // Pouzijeme image komponentu tlacitka

        // Spustime fade-in s odpovidajicim zpozdenim
        StartCoroutine(FadeInWithDelay(text1, delayText1));
        StartCoroutine(FadeInWithDelay(text2, delayText2));
        StartCoroutine(FadeInWithDelay(text3, delayText3));
        StartCoroutine(FadeInWithDelay(button.image, delayButton)); // Tlacitko se objevi zaroven s textem 3
    }

    private void SetAlpha(Graphic obj, float alpha)
    {
        if (obj != null)
        {
            Color color = obj.color;
            color.a = alpha;
            obj.color = color;
        }
    }

    private IEnumerator FadeInWithDelay(Graphic obj, float delay)
    {
        if (obj == null) yield break;

        yield return new WaitForSeconds(delay);

        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsed / fadeDuration);
            SetAlpha(obj, alpha);
            yield return null;
        }
        SetAlpha(obj, 1); // Ujistime se, ze alpha je 1 na konci
    }
}
