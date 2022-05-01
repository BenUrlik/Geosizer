using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSpawner : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBlock() {
        GameObject newButton = Instantiate(button) as GameObject;
        newButton.transform.SetParent(panel.transform, false);
    }

    public void findCenter() {

    }

    public void spawnLevel() {

    }
}
