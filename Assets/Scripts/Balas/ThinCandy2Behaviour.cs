using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinCandy2Behaviour : MonoBehaviour {

    public GameObject ThinCandy2;
    public GameObject BarraDeVida;
    static float speedCandy2 = 10;

    void Start () {
      
    }
	
	void Update () {
        transform.position -= new Vector3(0, speedCandy2, 0) * Time.deltaTime;
        

        if (transform.position.y < -12) {
            Destroy(ThinCandy2.gameObject);
        }
    }

}
