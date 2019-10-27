using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PulmController : MonoBehaviour {

    float dirX;
    public float moveSpeed = 5f, jumpForce = 1200f;
    Rigidbody2D rb;
    bool facingRight = true;
    Vector3 localScale;
    private Animator animator;
    public Transform ground;
    private bool isGround;
    public int life;
    public int moedas;
    PlayerStats playerStats = new PlayerStats();

    // Use this for initialization
    void Start () {
        life = 3;
        moedas=0;
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D> ();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update () {

        isGround = Physics2D.Linecast (transform.position, ground.position, 1 << LayerMask.NameToLayer ("Ground"));

        dirX = CrossPlatformInputManager.GetAxis ("Horizontal");

        if (CrossPlatformInputManager.GetButtonDown ("Jump")) {
            DoJump ();
        }

        if (isGround == false) {
            animator.SetBool ("noChao", false);
        } else {
            animator.SetBool ("noChao", true);
        }

        if (dirX != 0 && isGround == true) {
            animator.SetBool ("noChao", true);
            animator.SetBool ("seMovendo", true);
        } else {
            animator.SetBool ("seMovendo", false);
        }

    }

    public void DoJump () {
        if (isGround) {
            //rb.AddForce (Vector2.up * 700f, ForceMode2D.Force);
            // rb.AddForce(new Vector2.up(0,700), ForceMode2D.Impulse);
            rb.AddForce (new Vector2 (0f, 700f), ForceMode2D.Force);
            animator.SetBool ("noChao", false);
        }
    }

    void FixedUpdate () {
        rb.velocity = new Vector2 (dirX * moveSpeed, 0);
    }

    void LateUpdate () {
        CheckWhereToFace ();
    }

    void CheckWhereToFace () {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    public void perderVida(){
        life--;
        playerStats.life = life;
        RestClient.Put("https://thehealthgame-86a75.firebaseio.com/teste.json",playerStats);
    }

    public void ganharVida(){
        life++;
    }

}