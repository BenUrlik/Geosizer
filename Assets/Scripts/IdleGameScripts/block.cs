using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public float hitCounter;
    public GameObject managerObj;
    //public Text blockCountText;
    
    void Start() {
        manager managerScript= managerObj.GetComponent<manager>();
        hitCounter = managerScript.levelNum;
        //``blockCountText = this.gameObject.GetChildComponent<Text>();
    }
}
