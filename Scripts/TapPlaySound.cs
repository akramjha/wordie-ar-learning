using UnityEngine;
using Lean.Touch;

public class TapPlaySound : MonoBehaviour
{
    public AudioSource audioSource; // assign your sound here

    void OnEnable()
    {
        LeanTouch.OnFingerTap += HandleTap;
    }

    void OnDisable()
    {
        LeanTouch.OnFingerTap -= HandleTap;
    }

    private void HandleTap(LeanFinger finger)
    {
        // Raycast from finger to 3D world
        Ray ray = finger.GetRay();
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                // Play the sound
                if (audioSource != null)
                {
                    audioSource.Play();
                }
            }
        }
    }
}