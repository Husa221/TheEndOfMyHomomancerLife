using UnityEngine;
using System.Collections;

public class AnimationUI : MonoBehaviour
{
    public Animator animator;
    public float delay = 3f; // Delay time in seconds

    void Start()
    {
        StartCoroutine(PlayAnimationAfterDelay());
    }

    private IEnumerator PlayAnimationAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        animator.Play("YourAnimationName"); // Replace with the actual animation name
    }
}
