using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    Animator Anim;

    public GameObject player;

    public float maxWidth;
    public float minWidth;
    private float posY = -5;
    private int controlerSpeed;
    private bool candyTest = true;
    //static int score;
    //public TextMesh pontos;

    void Start() {
        Anim = GetComponent<Animator>();       
    }

    void Update() {

        float translationX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(translationX, 0.0f, 0.0f);
        
        // player.transform.Translate(0, translationX, 0);

        if (player.transform.position.x > maxWidth) {
            player.transform.position = new Vector2(maxWidth, posY);
        }

        if (player.transform.position.x < minWidth) {
            player.transform.position = new Vector2(minWidth, posY);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
            Anim.ResetTrigger("Parado");
            Anim.ResetTrigger("Esquerda");
            Anim.SetTrigger("Direita");
        }else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            Anim.ResetTrigger("Parado");
            Anim.ResetTrigger("Direita");
            Anim.SetTrigger("Esquerda");
        } else {        
            Anim.SetTrigger("Parado");
        }

       // pontos.text = score.ToString();

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) 
            Anim.ResetTrigger("Direita");
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            Anim.ResetTrigger("Esquerda");
    }
    
    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "candy" || col.tag == "candy2" || col.tag == "candy3" || col.tag == "candy4") {
            Destroy(col.gameObject);
        }

        if(col.tag == "candy2" && candyTest) {           
            speed += 0.2f;
            candyTest = false;
        }

        if (col.tag == "candy" && !candyTest || col.tag == "candy4" && !candyTest) {
            speed -= 0.2f;
            candyTest = true;
        }
    }

}
