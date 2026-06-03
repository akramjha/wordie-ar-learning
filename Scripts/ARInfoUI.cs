using UnityEngine;

public class ARInfoUI : MonoBehaviour
{
    public GameObject infoPanel;

    public void ShowInfo()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}