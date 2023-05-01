using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject summoning;
    public GameObject spawnPoint;
    public GameObject checkPoint;
    public AudioSource audioSource;
    public AudioClip BigFart;
    public GameObject lennyFace;
    public GameObject buttFace;
    public Transform currentCheckpoint;
    public TMP_Text livesText;
    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        summoning = GameObject.Find("Summoning");
    }

    // Update is called once per frame
    void Update()
    {
        livesText.SetText("Lives: " + pc.lives);
    }

    public void Respawn()
    {
        player.transform.position = currentCheckpoint.position;
    }
    public void Play()
    {
        SceneManager.LoadScene("Cutscene");
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
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void GameOver()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        Storage.currentSceneName = sceneName;
        SceneManager.LoadScene("gameover");
    }
    public void Title()
    {
        SceneManager.LoadScene("title");
    }
    public void Restart()
    {
        SceneManager.LoadScene(Storage.currentSceneName);
    }
}
