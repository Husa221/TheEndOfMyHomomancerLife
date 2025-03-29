using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public float time = 100;
    [SerializeField] float timerMaxBar = 100;
    public Image timersBarMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DecreaseScoreOverTime());
    }

    IEnumerator DecreaseScoreOverTime()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1f); // poèkej 1 sekundu
            time -= 1;
            Debug.Log("time remaining;" + time);
        }

        Debug.Log("You dead lol");
    }
    // Update is called once per frame
    void Update()
    {
        GetStressBarFilled();
    }
    void GetStressBarFilled()
    {
        if (timersBarMask == null)
        {
            Debug.Log("missingmaskcomoponent");
            return;
        }

        float fillAmount = time / timerMaxBar;
        timersBarMask.fillAmount = fillAmount;
    }
}
