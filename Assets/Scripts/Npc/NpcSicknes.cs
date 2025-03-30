using System.Collections;
using UnityEngine;
using static NpcShowBloodType;

public class NpcSicknes : MonoBehaviour
{
    [SerializeField] GameObject npcBloodUI;
    public BloodType sickBloodType;
    NPCBloodTrigger nPCBloodTrigger;
    PlayerMovement playerMovement;
    public Animator sicknessAnimator;
    AnimControler animControler;
    private bool closeEnough = false;
    [SerializeField] GameObject badBloodType;
    [SerializeField] float infoTimer = 2f;

    private void Awake()
    {
        nPCBloodTrigger = FindAnyObjectByType<NPCBloodTrigger>();
        animControler = FindAnyObjectByType<AnimControler>();
        playerMovement = FindAnyObjectByType<PlayerMovement>();

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
                if (!playerMovement.isDoingMagic)
                {
                    GiveBlood();
                }
                    sicknessAnimator.SetTrigger("ishealed");
                
                
            }
            else
            {
                Debug.Log("spatnej typ krve");
                StartCoroutine(BadBloodType());
            }
        }
    }

    void GiveBlood()
    {
        NPCCounter.npcCounter++;
    animControler.Wooloo();
    }
    IEnumerator BadBloodType()
    {
        badBloodType.SetActive(true);
        yield return new WaitForSeconds(infoTimer);
        badBloodType.SetActive(false);
    }
}
