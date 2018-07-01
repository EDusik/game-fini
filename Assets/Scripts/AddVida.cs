using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddVida : MonoBehaviour {

    public float vida = 100;
    public Image BarraVida;

    // Use this for initialization
    void Start() {
        BarraVida = BarraVida;
        BarraVida.fillAmount = (vida / 100);
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "candy" && vida != 100) {
            vida += 20;
            //Destroy(col.gameObject);
            BarraVida.fillAmount = (vida / 100);
            Debug.Log(vida);

        }
    }
}
