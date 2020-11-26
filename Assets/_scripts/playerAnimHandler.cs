using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimHandler : MonoBehaviour {

    private Animator anim;
    private playerMovement movementScript;

    void Awake() {
        anim = GetComponent<Animator>();
        movementScript = GetComponent<playerMovement>();
    }

    void Update() {
        anim.SetBool("running", movementScript.IsRunning());
    }
}
