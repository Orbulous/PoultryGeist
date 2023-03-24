using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChase : MonoBehaviour
{

    public PlayerController Player;

    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<PlayerController>();

        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           // StartChase();
        }

       // Public void StartChase()
       // {
         //   Enemy.active;
      //  }
    }
}
