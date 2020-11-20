using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    private float h, v;

    public float speed = 5f;

    private Rigidbody2D rb;

    void Start() {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {

        h = Input.GetAxisRaw("Horizontal");
        Debug.Log(h);
    }

    private void FixedUpdate() {

        transform.position += new Vector3(h * speed * Time.deltaTime, 0, 0);
    }
}
