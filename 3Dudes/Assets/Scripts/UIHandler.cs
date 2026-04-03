using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public void ButtonClick()
    {
        Debug.Log("Button clicked!");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ButtonClick();
        }
    }
}
