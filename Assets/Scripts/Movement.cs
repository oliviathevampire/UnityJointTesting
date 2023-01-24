using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private Rigidbody2D _rb;

    public float speed;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetKey(KeyCode.A))
            _rb.velocity = Vector2.left * (speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            _rb.velocity = Vector2.right * (speed * Time.deltaTime);
    }
}