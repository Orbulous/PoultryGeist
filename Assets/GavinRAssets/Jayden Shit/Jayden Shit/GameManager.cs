using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject summoning;
    public GameObject spawnPoint;
    public GameObject checkPoint;
    public bool spawn;
    public bool check;
    public AudioSource audioSource;
    public AudioClip BigFart;
    public GameObject lennyFace;
    public GameObject buttFace;

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
        check = false;
    }

    public void Respawn()
    {
          //  player.transform.position = checkPoint.transform.position;
          //  check = true;
            player.transform.position = spawnPoint.transform.position;
            spawn = true;
    }
    public void Play()
    {
        SceneManager.LoadScene("Level-1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Fart()
    {
        audioSource.PlayOneShot(BigFart);
        lennyFace.GetComponent<SpriteRenderer>().enabled = false;
        buttFace.GetComponent<SpriteRenderer>().enabled = true;
    }
}
