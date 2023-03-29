using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetecter : MonoBehaviour
{
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                EnemyScript ed = transform.parent.GetComponent<EnemyScript>();

                ed.isHitOnHead = true;
                ed.player = collision.gameObject;
                ed.Die();
            }
        }
}
