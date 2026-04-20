using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad = "SampleScene"; 
    private bool toggle = false;

    public void SwitchScene()
    {
        toggle = !toggle;

        if (toggle)
            SceneManager.LoadScene(sceneToLoad);
        else
            SceneManager.LoadScene("PR03_UI_Reactions");
    }
}