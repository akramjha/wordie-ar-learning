using UnityEngine;

public class SettingsAudioUI : MonoBehaviour
{
    [Header("Music")]
    public GameObject musicOn;
    public GameObject musicOff;

    [Header("SFX")]
    public GameObject sfxOn;
    public GameObject sfxOff;

    // MUSIC
    public void TurnMusicOff()
    {
        AudioManager.instance.bgMusicSource.mute = true;

        musicOn.SetActive(false);
        musicOff.SetActive(true);
    }

    public void TurnMusicOn()
    {
        AudioManager.instance.bgMusicSource.mute = false;

        musicOn.SetActive(true);
        musicOff.SetActive(false);
    }

    // SFX
    public void TurnSfxOff()
    {
        AudioManager.instance.sfxSource.mute = true;

        sfxOn.SetActive(false);
        sfxOff.SetActive(true);
    }

    public void TurnSfxOn()
    {
        AudioManager.instance.sfxSource.mute = false;

        sfxOn.SetActive(true);
        sfxOff.SetActive(false);
    }
}