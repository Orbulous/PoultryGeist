using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool isHitOnHead;
    public GameObject player;
    public float bounceForce;
    public Transform groundDetector;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

        if (groundDetector != null)
        {
            RaycastHit2D ground = Physics2D.Raycast(groundDetector.position, Vector2.down, .5f);
            if (ground.collider == null)
            {
                transform.Rotate(0, 180, 0);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            if (isHitOnHead)
            {
                Die();
            }
            else
            {
                player.GetComponent<PlayerController>().Hurt();
            }
        }
    }

    public void Die()
    {
        player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        Destroy(gameObject);
    }
}
