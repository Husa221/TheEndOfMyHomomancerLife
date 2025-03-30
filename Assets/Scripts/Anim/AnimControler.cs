using UnityEngine;

public class AnimControler : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    [SerializeField] Transform grafics;
    PlayerMovement playerMovement;
    [SerializeField] AudioSource walkSound;
    bool walkSoundIsPlaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerMovement = GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.x < -0.1f)
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIddling", false);
            grafics.localScale = new Vector3(1, grafics.localScale.y, grafics.localScale.z);
        }
        else if (rb.linearVelocity.x > 0.1f)
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIddling", false);
            grafics.localScale = new Vector3(-1, grafics.localScale.y, grafics.localScale.z);
        } else if (rb.linearVelocity.y < -0.1 || rb.linearVelocity.y > 0.1f)
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIddling", false);
        } else if (rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0)
        {
            walkSoundIsPlaying = false;
            animator.SetBool("isRunning", false);
            animator.SetBool("isIddling", true);
        }
        if((rb.linearVelocity.x != 0 && rb.linearVelocity.y != 0) && !walkSoundIsPlaying)
        {
            walkSound.Play();
            walkSoundIsPlaying = true;
        }
       
    }
    public void Wooloo() 
    {
       
        playerMovement.isDoingMagic = true;
        animator.SetTrigger("isWololing");
    }
    public void Death()
    {
       
        playerMovement.isDoingMagic = true;
        animator.SetTrigger("isDying");
    }
}
