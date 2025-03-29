using UnityEngine;

public class CureEvent : MonoBehaviour
{
    [SerializeField] GameObject cowToMercileslyKill; 

    public void DestroyCow()
    {
        cowToMercileslyKill.SetActive(false);
    }
}
