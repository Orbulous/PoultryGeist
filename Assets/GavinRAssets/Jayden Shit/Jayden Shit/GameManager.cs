using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject summoning;
    public GameObject spawnPoint;
    public bool spawn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        summoning = GameObject.Find("Summoning");
    }

    // Update is called once per frame
    void Update()
    {
        spawn = false;
    }
    
    public void Respawn()
    {
<<<<<<< Updated upstream
        player.transform.position = spawnPoint.transform.position;
        spawn = true;
=======
            //player.transform.position = checkPoint.transform.position;
            //check = true;
            player.transform.position = spawnPoint.transform.position;
            spawn = true;
>>>>>>> Stashed changes
    }
    
}
