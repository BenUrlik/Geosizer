using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Text clickerCount; 
    public float clickNum;

    // Start is called before the first frame update
    void Start()
    {
        clickNum = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickUpdate() {
        ++clickNum;
        clickerCount.text = clickNum.ToString("0");
    }
}
