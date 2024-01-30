
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    private void Start()
    {
        // Assuming you have a Button component attached to the same GameObject,
        // you can subscribe the QuitGame method to the button's onClick event.
        Button quitButton = GetComponent<Button>();

        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
        else
        {
            Debug.LogError("QuitButton script is attached to an object without a Button component.");
        }
    }

    // This method is called when the quit button is clicked
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
