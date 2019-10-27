using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private GameController gameController;
    public Sprite[] itens;
    public Image imgItem1;
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
            imgItem1.sprite = itens[0]; 
            Destroy(gameObject);
        }    
    }
}
