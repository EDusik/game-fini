using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pontuacao : MonoBehaviour {
    
    static int score;
    public TextMesh pontos;    

    // Use this for initialization
    void Start () {
        pontos = pontos;
    }
	
	// Update is called once per frame
	void Update () {
        pontos.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "candy") {
             score += 10;
        }

        if (col.tag == "candy2") {
            score += 50;
        }

        if (col.tag == "candy3") {
            score += 25;
        }

        if (col.tag == "candy4") {
            score += 5;
        }
    }
      
    void OnEnable() {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable() {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon 
        //as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode) {
        if(scene.name == "Game") {
            score = 0;
        }
    }
}