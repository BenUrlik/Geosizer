using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void playScene() {
        Debug.Log("Going to the Play Scene");
        SceneManager.LoadScene("PlayScene");
    }
    
    public void changeScene(Scene Sce) {
        Debug.Log(Sce);
        // SceneManager.LoadScene(Sce);
    }
}
