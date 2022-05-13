using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour
{
    public float hitCounter;
    public GameObject managerObj;
    public manager managerScript;
    public Text blockCountText;
    
    void Start() {
        managerObj = GameObject.FindWithTag("manager");
        managerScript= managerObj.GetComponent<manager>();
        hitCounter = managerScript.levelNum;
        blockCountText = GetComponentInChildren<Text>();
        blockCountText.text = hitCounter.ToString();
    }

    // Constantly update the block text to the current hitcounter
    void Update() { blockCountText.text = hitCounter.ToString(); }

    // Updates the block information when a player clicks one of the blocks
    // Used in the OnClick() Function of the blocks
    public void playerClick() {
        float temp = hitCounter;
        hitCounter -= (1.0f + managerScript.clickAssist);

        // If the block is destroyed by a player click:
        // Update the score and destroy the block
        if(hitCounter <= 0.0f) {
            managerScript.collisionUpdate(temp);
            managerScript.blockDestroyed();
            Destroy(gameObject);
        }
        // Otherwise treat it like a ball collision
        // And update the score
        else { 
            managerScript.collisionUpdate(1 + managerScript.clickAssist); 
        }
    }
}
