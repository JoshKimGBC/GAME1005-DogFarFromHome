using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    private Camera cam;
    public GameObject player;

    private float horizontalCutOff, verticalHighCutOff, verticalLowCutOff, verticalLowStop;
    Vector2 playerPos;

    public float scrollSpeed = 10f;

    private void Awake() {

        cam = GetComponent<Camera>();

        horizontalCutOff = cam.pixelWidth * 0.66f;
        verticalHighCutOff = cam.pixelHeight * 0.66f;
        verticalLowCutOff = cam.pixelHeight * 0.33f;

        verticalLowStop = cam.transform.position.y;
    }
    // Update is called once per frame
    void Update() {

        playerPos = cam.WorldToScreenPoint(player.transform.position);
    }

    private void FixedUpdate() {
        // scrollSpeed * Time.deltaTime

        if (playerPos.x > horizontalCutOff)
            transform.position += new Vector3(scrollSpeed * Time.deltaTime, 0, 0);

        if (playerPos.y > verticalHighCutOff)
            transform.position += new Vector3(0, scrollSpeed * Time.deltaTime, 0);

        if (playerPos.y < verticalLowCutOff && transform.position.y > verticalLowStop)
            transform.position += new Vector3(0, -scrollSpeed * Time.deltaTime, 0);
    }
}
