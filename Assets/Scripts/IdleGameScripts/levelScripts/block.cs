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

    void Update() { blockCountText.text = hitCounter.ToString(); }

    public void updateHitCount() {
        hitCounter += 1 + managerScript.clickAssist; 
    }

    public void playerClick() {
        hitCounter -= (1.0f + managerScript.clickAssist);

        if(hitCounter <= 0.0f) {
            managerScript.collisionUpdate(1 + managerScript.clickAssist);
            Destroy(gameObject);
        }
        else { managerScript.clickUpdate(); }
    }
}
