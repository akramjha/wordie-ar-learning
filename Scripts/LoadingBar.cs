using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
    public Image loadingFill;   // drag your fill image here
    public float duration = 4f; // 4 seconds

    private float timer = 0f;

    void Update()
    {
        if (timer < duration)
        {
            timer += Time.deltaTime;

            // calculate fill (0 → 1)
            float progress = timer / duration;
            loadingFill.fillAmount = progress;
        }
        else
        {
            // ensure full
            loadingFill.fillAmount = 1f;

            // load next scene
            SceneManager.LoadScene("Main menu");
        }
    }
}