using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }
    public float speed = 500f;

    private void Awake() {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start() {
        Invoke(nameof(SetRandomTrajectory), 1.0f);
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void SetRandomTrajectory() {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1.0f, 1.0f);
        force.y = Random.Range(-1.0f, 1.0f);

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
}
