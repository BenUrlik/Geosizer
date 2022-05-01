using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Text moneyText; 
    public Text levelText;
    public float clickNum;
    public float levelNum;

    // Start is called before the first frame update
    void Start()
    {
        clickNum = 0;   
        levelNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickUpgrade() {
        
    }

    public void clickUpdate() {
        ++clickNum;
        moneyText.text = clickNum.ToString("0");
    }

    public void spawnBall() {

    }


}
