using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemController : MonoBehaviour {
    public float speed = 2.0f;
    public float timeChance;
    public float timeShot;
    private float currentTimeChance;
    private float currentTimeShot;
    private bool isRight = false;
    public GameObject prefabGota;
    private GameController gameController;

    // Start is called before the first frame update
    void Start () {
        gameController = FindObjectOfType (typeof (GameController)) as GameController;
    }

    // Update is called once per frame
    void Update () {
        if (gameController.CurrentState == StateMachine.INGAME) {
            Movimento ();
            Chover ();
        }

    }

    private void Movimento () {
        currentTimeChance += Time.deltaTime;
        currentTimeShot += Time.deltaTime;
        if (currentTimeChance >= timeChance) {
            if (isRight == false) {
                isRight = true;
                speed *= -1;
            } else {
                isRight = false;
                speed *= 1;
            }
            currentTimeChance = 0;
        }

        transform.Translate (speed * Time.deltaTime, 0, 0);

    }

    private void Chover () {

        if (currentTimeShot > timeShot) {
            Instantiate (prefabGota, transform.position, transform.rotation);
            currentTimeShot = 0;
        }
    }
}