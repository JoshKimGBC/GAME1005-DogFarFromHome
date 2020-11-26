using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Camera cam;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private bool jumping = false;
    private float h;

    public float speed = 5f;
    public float jumpVelocity = 100f;

    void Start() {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {

        // Flips sprite if you're moving backwards
        sr.flipX = h < -0.01;

        // sets h to normalized horizontal value
        h = Input.GetAxisRaw("Horizontal");
        h = h > 0.1 ? 1 : h < -0.1 ? -1 : 0;

        if (cam.WorldToScreenPoint(transform.position).x < cam.pixelWidth * 0.03 && h == -1)
            h = 0;

        // Tracks if the user presses the jump button
        if (Input.GetButtonDown("Jump"))
            jumping = true;

    }

    private void FixedUpdate() {

        // Horizontal velocity
        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        // Jump code
        if (jumping) {
            jumping = false;
            rb.AddForce(new Vector2(0, jumpVelocity), ForceMode2D.Impulse);
        }
    }

    public bool IsRunning() {
        return Mathf.Abs(h) > 0.01;
    }
}
