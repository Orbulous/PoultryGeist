using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
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
        RaycastHit2D ground = Physics2D.Raycast(groundDetector.position, Vector2.down, .5f);
        if (ground.collider == null)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
