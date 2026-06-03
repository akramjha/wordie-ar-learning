using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Sources")]
    public AudioSource bgMusicSource;
    public AudioSource sfxSource;

    [Header("SFX Clips")]
    public AudioClip buttonClickSfx;

    private bool isMusicMuted = false;
    private bool isSfxMuted = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        bgMusicSource.loop = true;

        bool musicOn = PlayerPrefs.GetInt("MusicOn", 1) == 1;
        bool sfxOn = PlayerPrefs.GetInt("SfxOn", 1) == 1;

        bgMusicSource.mute = !musicOn;
        sfxSource.mute = !sfxOn;

        if (!bgMusicSource.isPlaying)
        {
            bgMusicSource.Play();
        }
    }

    // MUSIC
    public void ToggleMusic()
    {
        isMusicMuted = !isMusicMuted;
        bgMusicSource.mute = isMusicMuted;
    }

    // SFX
    public void ToggleSfx()
    {
        isSfxMuted = !isSfxMuted;
        sfxSource.mute = isSfxMuted;
    }

    // BUTTON CLICK SOUND
    public void PlayButtonClick()
    {
        if (!isSfxMuted)
        {
            sfxSource.PlayOneShot(buttonClickSfx);
        }
    }
}