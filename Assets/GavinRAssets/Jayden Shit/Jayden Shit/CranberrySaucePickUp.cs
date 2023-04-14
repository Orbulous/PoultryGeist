using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CranberrySaucePickUp : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector2.up, 1);
    }

    public void JumpBoost()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().jumpForce = 14;
        Destroy(gameObject);
    }
}
