using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 600f;
    public Vector2 screenBounds;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 5000);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update() {
        // SetRandomTrajectory();
    }

    private void SetRandomTrajectory() {
        // Vector2 force = Vector2.zero;
        // force.x = Random.Range(-1.0f, 1.0f);
        // force.y = Random.Range(-1.0f, 1.0f);
        // this.GetComponent<Rigidbody>().AddForce(force.normalized * this.speed);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "block") {
            block blockScript = other.gameObject.GetComponent<block>();
            if(blockScript.hitCounter == 0.0f) {
                Destroy(other.gameObject);
            }
            else { blockScript.hitCounter--; }
        }
    }
}
