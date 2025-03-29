using UnityEngine;

public class NpcAnim : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    [SerializeField] Transform grafics;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.x < -0.1f)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
            grafics.localScale = new Vector3(1, grafics.localScale.y, grafics.localScale.z);
        }
        else if (rb.linearVelocity.x > 0.1f)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
            grafics.localScale = new Vector3(-1, grafics.localScale.y, grafics.localScale.z);
        }
        else if (rb.linearVelocity.y < -0.1 || rb.linearVelocity.y > 0.1f)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }

    }
}
