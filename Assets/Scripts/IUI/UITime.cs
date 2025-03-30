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
    AnimControler animControler;

    [SerializeField] bool debugtime = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DecreaseScoreOverTime());
        animControler = FindAnyObjectByType<AnimControler>();
    }

    IEnumerator DecreaseScoreOverTime()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1f); // poèkej 1 sekundu
            time -= 1;
            if (debugtime)
            Debug.Log("time remaining;" + time);
        }

        Debug.Log("You dead lol");
        //SceneManager.LoadScene("ScoreBoard");
        animControler.Death();
    }
    // Update is called once per frame
    void Update()
    {
        GetStressBarFilled();
        if(NPCCounter.npcCounter >= NPCCounter.allNpc)
        {
            SceneManager.LoadScene("ScoreBoard");
        }
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
