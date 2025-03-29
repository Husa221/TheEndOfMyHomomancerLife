using UnityEngine;
using static NpcShowBloodType;

public class NpcSicknes : MonoBehaviour
{
    [SerializeField] GameObject npcBloodUI;
    public BloodType sickBloodType;
    NPCBloodTrigger nPCBloodTrigger;
    private bool closeEnough = false;

    private void Awake()
    {
        nPCBloodTrigger = FindAnyObjectByType<NPCBloodTrigger>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Opustili jsme trigger s BloodReceiver!");
            closeEnough = true;
            npcBloodUI.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            closeEnough = false;
            Debug.Log("Opustili jsme trigger s BloodReceiver!");
            npcBloodUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && closeEnough)
        {
            if(nPCBloodTrigger.currentBloodType == sickBloodType)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("spatnej typ krve");
            }
        }
    }
}
