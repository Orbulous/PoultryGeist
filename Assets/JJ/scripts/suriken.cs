using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suriken : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public float moveSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

    }
    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("drone"))
        {
            Destroy(collision.gameObject);
        }
    }
}
