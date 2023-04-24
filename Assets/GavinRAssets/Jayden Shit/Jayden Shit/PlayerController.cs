using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float horizontalInput;
    public bool isOnGround = true;
    public float jumpForce;
    public float lowerLimit;
    public GameManager gm;
    public Animator animator;
    public GameObject pp;
    public GameObject cs;
    public float lives;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
        pp = GameObject.Find("Pumpkin Pie");
        pp.GetComponent<PumpkinPiePickUp>();
        cs = GameObject.Find("Cranberry Sauce");
        cs.GetComponent<CranberrySaucePickUp>();
        lives = 3;
    }

    void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Respawn();
            lives--;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveSpeed * horizontalInput * Time.deltaTime);
        if (horizontalInput < 0)
        {
            sr.flipX = true;
            animator.SetFloat("moveSpeed", moveSpeed);
        }
        else if (horizontalInput > 0)
        {
            sr.flipX = false;
            animator.SetFloat("moveSpeed", moveSpeed);
        }
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            isOnGround = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (lives == 0)
        {
            gm.GameOver();
        }
    }
    public void Hurt()
    {
        gm.Respawn();
        lives--;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("PP Pick Up"))
        {
            GameObject.Find("Pumpkin Pie").GetComponent<PumpkinPiePickUp>().SpeedBoost();
        }
        if (collision.gameObject.CompareTag("CS Pick Up"))
        {
            GameObject.Find("Cranberry Sauce").GetComponent<CranberrySaucePickUp>().JumpBoost();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CheckPoint"))
        {
            gm.currentCheckpoint = collision.transform;
        }
    }
}
