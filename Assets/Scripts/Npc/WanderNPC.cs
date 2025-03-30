using UnityEngine;

public class WanderNPC : MonoBehaviour
{
    public float moveRadius = 3f;
    public float moveSpeed = 2f;
    public float maxWaitTime = 2f;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    public bool isWaiting = false;

    public Animator animator;
    [SerializeField] Transform grafics;

    void Start()
    {
        startPosition = transform.position;
        PickNewDestination();
    }

    void Update()
    {

        if (isWaiting) 
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
            return; 
        }
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        Vector3 direction = targetPosition - transform.position;
        if (direction.x != 0)
        {
            FlipGrafics(direction.x);
        }
        animator.SetBool("isWalking", true);
        animator.SetBool("isIdle", false);


        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isWaiting = true;
            Invoke(nameof(PickNewDestination), Random.Range(1f, maxWaitTime));
        }
    }

    void PickNewDestination()
    {
        Vector2 randomOffset = Random.insideUnitCircle * moveRadius;
        targetPosition = startPosition + new Vector3(randomOffset.x, randomOffset.y, 0f);
        isWaiting = false;
    }
    void FlipGrafics(float moveDirectionX)
    {
        Vector3 scale = grafics.localScale;
        scale.x = moveDirectionX < 0 ? 1 : -1;
        grafics.localScale = scale;
    }
}
