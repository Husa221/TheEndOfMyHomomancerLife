using System.Collections;
using UnityEngine;

public class Bleeding : MonoBehaviour
{
    [SerializeField] GameObject[] bleedingPrefab;
    [SerializeField] float timeOfBlood = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(bleedingOverTime());
    }
IEnumerator bleedingOverTime()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(bleedingPrefab[Random.Range(0, bleedingPrefab.Length)], gameObject.transform);
    }
    
}
