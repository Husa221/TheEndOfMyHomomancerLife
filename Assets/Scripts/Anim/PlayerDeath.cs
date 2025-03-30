using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] AudioSource deathAudio;
    public void PlaySound()
    {
        deathAudio.Play(); 
    }
}
