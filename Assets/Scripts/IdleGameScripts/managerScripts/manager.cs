using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    // UI variables
    public Text moneyText; 
    public Text levelText;
    public float score;

    // Level Variables
    public float levelNum;
    public float blockCount;
    public float defBallCount;

    // For spawning the balls
    public GameObject ball;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        score = 0.0f;   
        levelNum = 1.0f;
        blockCount = 6.0f;
        defBallCount = 1.0f;
    }

    public void clickUpgrade() {
    }

    // Updates the blocks if the player clicks and it doesnt destroy the block
    public void clickUpdate() {
        ++score;
        moneyText.text = score.ToString();
    }

    // Happens every time a ball collides with a block and when a player clicks to destroy a block
    public void collisionUpdate() {
        --blockCount;
        ++score;
        moneyText.text = score.ToString();
    }

    // Spawns a new ball
    public void spawnBall() {
        if(score >= 10 && defBallCount < 10) {
            GameObject newBall = Instantiate(ball) as GameObject;
            newBall.transform.SetParent(panel.transform, false);
            score = score - 10;
            ++defBallCount;
        }
    }
}
