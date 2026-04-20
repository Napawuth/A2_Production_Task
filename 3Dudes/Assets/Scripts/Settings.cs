using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingsPanel;

    public void ToggleSettings()
    {
        settingsPanel.SetActive(!settingsPanel.activeSelf);
    }
    public void SetVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void ToggleFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int index)
    {
        if (index == 0)
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        else 
            Screen.SetResolution(1280, 720, Screen.fullScreen);
    }
}
