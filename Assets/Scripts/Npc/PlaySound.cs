using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

   public void Playsound()
    {
        audioSource.Play();
    }
}
