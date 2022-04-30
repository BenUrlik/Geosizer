using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void quitGame() {
        // Makes the editor quit playing the game
        UnityEditor.EditorApplication.isPlaying = false;
        // Makes the built version of the game quit
        Application.Quit();
    }
}
