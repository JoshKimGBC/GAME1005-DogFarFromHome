using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HasUI : MonoBehaviour {

    void Awake() {

        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
