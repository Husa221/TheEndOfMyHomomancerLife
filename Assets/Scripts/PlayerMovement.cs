using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 distance;
    Rigidbody2D rb2d;
    public float moveSpeed;
    public bool isDoingMagic = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        if (isDoingMagic )
        {
            
        }
    }
    private void FixedUpdate()
    {
        if (!isDoingMagic)
        {

            rb2d.linearVelocity = distance * moveSpeed;
        }
        if (isDoingMagic)
        {
            rb2d.linearVelocity = Vector2.zero;
        }
    }
}
