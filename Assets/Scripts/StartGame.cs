using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver() {
        if (Input.GetButtonDown("Fire1")) {
            // GetComponent<AudioSource>().Play();
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
    }
}
