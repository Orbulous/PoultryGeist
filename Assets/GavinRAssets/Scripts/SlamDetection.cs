using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamDetection : MonoBehaviour
{

    public PlayerController pc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            HitPlayer();
        }
    }

    public void HitPlayer()
    {
        Debug.Log("I hit the turkey!");
        pc.Hurt();
    }
}
