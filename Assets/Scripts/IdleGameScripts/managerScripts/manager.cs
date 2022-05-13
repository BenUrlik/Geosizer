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
    public float superBallCount;
    public float ultraBallCount;

    // Player clicker aspects
    public float clickAssist;

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
        superBallCount = 0.0f;
        ultraBallCount = 0.0f;
        clickAssist = 0.0f;
    }

    public void clickUpgrade() { 
        if(score >= 10 && clickAssist < 10) {
            ++clickAssist; 
            score -= 10;
        }
    }

    // Updates the blocks if the player clicks and it doesnt destroy the block
    public void clickUpdate() {
        ++score;
        moneyText.text = score.ToString();
    }

    // Happens every time a ball collides with a block and when a player clicks to destroy a block
    public void collisionUpdate(float damage) {
        score += damage;
        moneyText.text = score.ToString();
    }

    public void blockDestroyed() {
        --blockCount;
    }

    // Spawns a new ball
    public void spawnBall() {
        if(score >= 10 && defBallCount < 10) {
            GameObject newBall = Instantiate(ball) as GameObject;
            newBall.transform.SetParent(panel.transform, false);
            score -= 10;
            ++defBallCount;

            // Attempting to update the button text - Not working cause buttons dont instantiate after Start()
            // Text ballStr = defBallBut.GetComponent<Text>();
            // Debug.Log(ballStr.text);
            // defBallBut.Text.text = "Buy Ball: " + defBallCount.ToString(); 
        }
    }

    // Spawns a new super ball
    public void spawnSuperBall() {
        if(score >= 25 && superBallCount < 10) {
            GameObject newBall = Instantiate(ball) as GameObject;
            Image colorImage = newBall.GetComponent<Image>();
            colorImage.color = new Color32(255,0,0, 255);
            newBall.transform.SetParent(panel.transform, false);
            score = score - 25;
            ++superBallCount;
        }
    }

    // Spawns a new ultra ball
    public void spawnUltraBall() {
        if(score >= 50 && ultraBallCount < 10) {
            GameObject newBall = Instantiate(ball) as GameObject;
            Image colorImage = newBall.GetComponent<Image>();
            colorImage.color = new Color32(0,255,0, 255);
            newBall.transform.SetParent(panel.transform, false);
            score = score - 50;
            ++ultraBallCount;
        }
    }
}
