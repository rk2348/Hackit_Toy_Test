using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip soundClip;
    [SerializeField] private AudioSource audioSource;

    public void PlaySound()
    {
        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
        else
        {
            Debug.LogWarning("AudioSource �� AudioClip ���ݒ肳��Ă��܂���B");
        }
    }
}
