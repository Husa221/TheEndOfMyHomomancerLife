using UnityEngine;

public class NpcShowBloodType : MonoBehaviour
{
    [SerializeField] GameObject npcBloodUI;
    public BloodType bloodType;
    NPCBloodTrigger nPCBloodTrigger;
    private bool closeEnough = false;

    private void Awake()
    {
        nPCBloodTrigger= FindAnyObjectByType<NPCBloodTrigger>();
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
        if(Input.GetKeyDown(KeyCode.E) && closeEnough) 
        {
            nPCBloodTrigger.bloodUI[(int)nPCBloodTrigger.currentBloodType].SetActive(false);
           nPCBloodTrigger.currentBloodType = bloodType;
            nPCBloodTrigger.bloodUI[(int)nPCBloodTrigger.currentBloodType].SetActive(true);
            Debug.Log("Player Coppied:" +  nPCBloodTrigger.currentBloodType);
        }
    }
    public enum BloodType
    {
    A,
    B,
    AB,
    None
    }

}
