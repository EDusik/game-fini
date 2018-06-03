using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour{

    public TextMesh finalPontos;
    public static int score;

    void Start() {
        finalPontos.text = score.ToString();
    }

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
        }
    }
}
