using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour{

    void Start() {
    }

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Start");            
        }
    }
}
