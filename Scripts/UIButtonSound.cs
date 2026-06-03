using UnityEngine;
using UnityEngine.UI;

public class UIButtonSound : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlayButtonClick();
        }
    }
}