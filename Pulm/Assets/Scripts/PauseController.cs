using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour{

    public GameObject pausePanel;
    private bool isPaused;
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        gameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    public void Paused(){

        if(isPaused==false){
            gameController.CurrentState = StateMachine.PAUSED;
            pausePanel.SetActive(true);
            isPaused=true;
        }else{
            gameController.CurrentState = StateMachine.INGAME;
            pausePanel.SetActive(false);
            isPaused=false;
        }
    }
}