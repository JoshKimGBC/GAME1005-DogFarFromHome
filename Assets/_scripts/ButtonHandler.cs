using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]
    public Object firstLevel;

    public void StartGame() {

        SceneManager.LoadScene(2);
    }

    public void QuitGame() {

        Application.Quit();
    }

    public void Settings() {
    
    
    }
}
