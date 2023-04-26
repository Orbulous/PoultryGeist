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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpBoost();
    }

    public void JumpBoost()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().jumpForce = 65;
        Destroy(gameObject);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Thing Work or not idk");
        GameObject.Find("Player").GetComponent<PlayerController>().jumpForce = 14;
    }
}
