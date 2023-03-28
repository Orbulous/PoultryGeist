using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSticker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = transform;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.transform.parent = null;
        }
    }

}
