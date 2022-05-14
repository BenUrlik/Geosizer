using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSpawner : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public Vector2 screenBounds;
    public GameObject managerObj;
    public manager managerScript;

    // Start is called before the first frame update
    void Start()
    {
        managerScript= managerObj.GetComponent<manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(managerScript.blockCount <= 0.0f) {
            managerScript.blockCount = 6;
            ++managerScript.levelNum;
            managerScript.levelText.text = "Level " + managerScript.levelNum.ToString();
            spawnLevel();
        }
    }

    // Spawns the grid prefab
    public void spawnBlock() {
        GameObject newButton = Instantiate(button) as GameObject;
        newButton.transform.SetParent(panel.transform, false);
    }

    public void spawnLevel() {
        spawnBlock();
    }
}
