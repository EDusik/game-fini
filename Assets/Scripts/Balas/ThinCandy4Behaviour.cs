using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinCandy4Behaviour : MonoBehaviour {

    public GameObject ThinCandy2;
    public GameObject BarraDeVida;
    static float speedCandy4 = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0, speedCandy4, 0) * Time.deltaTime;
        speedCandy4 += 0.001f;

        if (transform.position.y < -12) {
            Destroy(ThinCandy2.gameObject);
        }
    }
}
