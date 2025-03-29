using UnityEngine;

public class WanderNPC : MonoBehaviour
{
    public float moveRadius = 3f;
    public float moveSpeed = 2f;
    public float maxWaitTime = 2f;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool isWaiting = false;

    void Start()
    {
        startPosition = transform.position;
        PickNewDestination();
    }

    void Update()
    {
        if (isWaiting) return;

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

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
}
