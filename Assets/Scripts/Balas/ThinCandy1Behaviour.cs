using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinCandy1Behaviour : MonoBehaviour {

    public GameObject ThinCandy1;
    public GameObject BarraDeVida;
    static float speedCandy = 4.5f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0, speedCandy, 0) * Time.deltaTime;
        speedCandy += 0.001f;
        
        if (transform.position.y < -12) {
            Destroy(ThinCandy1.gameObject);
        }
    }
}
