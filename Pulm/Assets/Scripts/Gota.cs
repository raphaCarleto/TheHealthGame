using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour {
    // Start is called before the first frame update
    private PulmController player;
    void Start () {
        player = FindObjectOfType (typeof (PulmController)) as PulmController;
    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter2D (Collider2D collider) {
        //colocar collider para destruir gotas 

        if (collider.tag == "Player") {
            player.perderVida();
        }

        if (collider.tag == "FimGotas") {
            Destroy(gameObject);
        }


    }
}