using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public float time = 100;
    [SerializeField] float timerMaxBar = 100;
    public Image timersBarMask;
    [SerializeField] bool debugtime = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DecreaseScoreOverTime());
    }

    IEnumerator DecreaseScoreOverTime()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1f); // po�kej 1 sekundu
            time -= 1;
            if (debugtime)
            Debug.Log("time remaining;" + time);
        }

        Debug.Log("You dead lol");
        SceneManager.LoadScene("ScoreBoard");
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
