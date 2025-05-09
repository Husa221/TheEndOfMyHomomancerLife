using System.Collections;
using UnityEngine;

public class Bleeding : MonoBehaviour
{
    [SerializeField] GameObject[] bleedingPrefab;
    [SerializeField] float timeOfBlood = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BleedingOverTime());
    }
IEnumerator BleedingOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeOfBlood);
            Instantiate(bleedingPrefab[Random.Range(0, bleedingPrefab.Length)], transform.position, transform.rotation);
        }
    }
    
}
