using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinCandy3Behaviour : MonoBehaviour {

    public GameObject ThinCandy3;
    public GameObject BarraDeVida;
    static float speedCandy2 = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0, speedCandy2, 0) * Time.deltaTime;

        if (transform.position.y < -12) {
            Destroy(ThinCandy3.gameObject);
        }
    }
}
