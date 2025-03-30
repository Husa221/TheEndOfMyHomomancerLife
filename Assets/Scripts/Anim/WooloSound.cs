using UnityEngine;

public class WooloSound : MonoBehaviour
{
    [SerializeField] AudioSource woolooAudio;
    public void WooloPlay()
    {
        woolooAudio.Play();
    }
}
