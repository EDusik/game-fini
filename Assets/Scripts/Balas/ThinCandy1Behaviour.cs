using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinCandy1Behaviour : MonoBehaviour {

    public GameObject ThinCandy1;
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;

        if (transform.position.y < -12) {
            Destroy(ThinCandy1.gameObject);

        }
    }
}
