using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound;

    public void PlayClick()
    {
        if (!AudioManager.instance.sfxSource.mute)
        {
            AudioManager.instance.sfxSource.PlayOneShot(clickSound);
        }
    }
}