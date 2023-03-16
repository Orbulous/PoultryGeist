using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 3f;
    public float detectionRadius = 5f;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;


    }

    // Update is called once per frame
    void Update()
    {

        // Check if player is within detection radius
        float distanceToPlayer = Vector2.Distance(transform.position, playerTransform.position);
        if (distanceToPlayer <= detectionRadius)
        {
            // Move towards player
            Vector2 direction = (playerTransform.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }


    }
    private void OnDrawGizmosSelected()
    {
        // Draw detection radius in editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
