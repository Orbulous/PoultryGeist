using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] spots;
    public float speed;
    public float size;
    public Animator anim;
    public GameObject hitRCollider;
    public float attackDelayTime;

    public Transform currentSpot;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSpot = spots[0];
        StartCoroutine("Boss");
        StartCoroutine(AttackPoint());

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Boss()
    {
        //First Attack


        Debug.Log("Boss Started");
        while (transform.position.x != currentSpot.position.x)
        {
            

            transform.position = Vector2.MoveTowards(transform.position, new Vector2(currentSpot.position.x, transform.position.y), speed * Time.deltaTime);
            yield return null;

        }
        
        if(transform.position.x == currentSpot.position.x)
        {
            StartCoroutine(Slam());
        }
     

    }

    IEnumerator Slam()
    {
        anim.SetTrigger("SlamR");
        yield return new WaitForSeconds(attackDelayTime);
        hitRCollider.SetActive(true);
    }

    IEnumerator AttackPoint()
    {
        //pick a random number
        int rando = Random.Range(0, spots.Length);
        currentSpot = spots[rando];
        yield return new WaitForSeconds(5);
        StartCoroutine(Boss());
        StartCoroutine(AttackPoint());


    }



}
