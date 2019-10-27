using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StateMachine {
    STARTGAME,
    INGAME,
    PAUSED,
    GAMEOVER,
    WINS
}

public class GameController : MonoBehaviour {

    public GameObject gameOverPanel;
    public GameObject pauseButton;
    private StateMachine stateMachine;
    public int contCoin;
    public Text txtCoinCount;
    public Sprite[] life;
    
    public Image imgLife;
    private PulmController player;

    // Start is called before the first frame update
    void Start () {
        stateMachine = StateMachine.STARTGAME;
        player = FindObjectOfType (typeof (PulmController)) as PulmController;
    }

    // Update is called once per frame
    void Update () {
        currentStateMachine ();
        CheckLife();
    }

    private void currentStateMachine () {
        switch (stateMachine) {
            case StateMachine.STARTGAME:
                {
                    StartGame ();
                }
                break;

            case StateMachine.INGAME:
                {

                }
                break;

            case StateMachine.PAUSED:
                {

                }
                break;

            case StateMachine.GAMEOVER:
                {

                }
                break;

            case StateMachine.WINS:
                {

                }
                break;
        }
    }

    public StateMachine CurrentState {
        get { return stateMachine; }
        set { stateMachine = value; }
    }

    public void StartGame () {
        CurrentState = StateMachine.INGAME;
    }

    public void CheckLife () {

        if (player.life == 0) {
            imgLife.sprite = life[3];
            CurrentState = StateMachine.GAMEOVER;
            pauseButton.SetActive(false);
            gameOverPanel.SetActive(true);
            Debug.Log("Game Over");
        } else if (player.life == 1) {
            imgLife.sprite = life[2];

        } else if (player.life == 2) {
            imgLife.sprite = life[1];

        } else if (player.life == 3) {
            imgLife.sprite = life[0];
        }
    }
}