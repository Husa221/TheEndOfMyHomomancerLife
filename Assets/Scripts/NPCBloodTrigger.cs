using UnityEngine;
using static NpcShowBloodType;

public class NPCBloodTrigger : MonoBehaviour
{
    private GameObject bloodReceiverObject;
    private bool isInTrigger = false;
    public BloodType currentBloodType;
    [SerializeField] GameObject[] bloodUI;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BloodReceiver"))
        {
            Debug.Log("BloodReceiver in right distance");
            bloodReceiverObject = other.gameObject;
            isInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("BloodReceiver"))
        {
            Debug.Log("Opustili jsme trigger s BloodReceiver!");
            isInTrigger = false;
        }
    }

    private void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            if (bloodReceiverObject != null)
            {
                Debug.Log("Intaraction");
                SpriteRenderer renderer = bloodReceiverObject.GetComponent<SpriteRenderer>();
                if (renderer != null)
                {
                    renderer.color = Color.red;  // Změna barvy na červenou
                }
            }
        }
    }
    
}
