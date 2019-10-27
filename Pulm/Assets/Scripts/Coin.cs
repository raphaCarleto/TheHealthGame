using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

private GameController gameController;
private PulmController pulm;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player"){
            gameController.contCoin+=100;
            gameController.txtCoinCount.text = gameController.contCoin.ToString();
            Destroy(gameObject);
        }    
    }
}
