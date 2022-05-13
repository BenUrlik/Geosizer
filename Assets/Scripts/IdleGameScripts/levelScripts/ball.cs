using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5000f;
    public Vector2 screenBounds;
    public GameObject managerObj;
    public manager managerScript;
    public bool isSuper = false;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 5000f);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        managerObj= GameObject.FindWithTag("manager");
        managerScript= managerObj.GetComponent<manager>();
    }

    private void SetRandomTrajectory() {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 1.0f);
        force.y = Random.Range(-0.5f, 1.0f);
        rb.AddForce(force.normalized * 7000f);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "block") {
            block blockScript = other.gameObject.GetComponent<block>();
            // Default ball collision
            if(blockScript.hitCounter == 1.0f) { 
                Destroy(other.gameObject); 
                managerScript.collisionUpdate(1); 
                managerScript.blockDestroyed();
            }
            else { blockScript.hitCounter--; managerScript.clickUpdate(); }
            
        }
        // If the ball does not collide with a block give it a random trajectory
        // And add some speed
        else if(other.collider.tag == "bottomWall") { SetRandomTrajectory(); }
        else if(other.collider.tag == "topWall") { SetRandomTrajectory(); }
        else if(other.collider.tag == "rightWall") { SetRandomTrajectory(); }
        else if(other.collider.tag == "leftmWall") { SetRandomTrajectory(); }
    }
}
