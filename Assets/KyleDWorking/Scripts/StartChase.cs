using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChase : MonoBehaviour
{

    public PlayerController Player;

    public GameObject EnemyChasing;

    public GameObject enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(StartChase());
        }

        IEnumerator StartChase()
        {
           yield return new WaitForSeconds(0);

            //Instantiate(prefab, spawn.position, spawn.rotation);

            Instantiate(EnemyChasing, enemySpawn.transform.position, enemySpawn.transform.rotation);
        }
    }
}
