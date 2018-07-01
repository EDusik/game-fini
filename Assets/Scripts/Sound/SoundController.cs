using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {


    public AudioSource[] sounds;
    public AudioSource noise1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "candy" || col.tag == "candy2" || col.tag == "candy3" || col.tag == "candy4") {
            noise1.Play();
        }
    }
}
