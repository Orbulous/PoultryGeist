using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] spots;
    public float speed;
    public float size;
    public Animator anim;
    public GameObject hitRCollider;
    public GameObject hitLCollider;
    public float attackDelayTime;
    public float attackSwitchTime;

    public Transform currentSpot;

    public float health = 500;

    public float bossTimer;

    public GameObject killCollider;
    public TextMeshProUGUI timer;

    public bool bossIsWeak = false;

    // Start is called before the first frame update
    void Start()
    {
        currentSpot = spots[0];
        StartCoroutine("Boss");
        StartCoroutine(AttackPoint());

        anim = GetComponent<Animator>();
        bossTimer = 40f;
        StartCoroutine(BossTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (bossTimer >= 0)
        {
            bossIsWeak = false;
         
            timer.SetText("Time: " + bossTimer);
        }
        else
        {
            bossIsWeak = true;
            anim.SetTrigger("Error");
            StopCoroutine(Boss());
            StopCoroutine(Slam());
            StopCoroutine(AttackPoint());
            StopCoroutine(BossTimer());
            killCollider.SetActive(true);
            timer.SetText("BOZOS IS WEAK! STRIKE NOW!");
        }
       
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

        if (transform.position.x == currentSpot.position.x)
        {
            StartCoroutine(Slam());
        }


    }

    IEnumerator Slam()
    {
        anim.SetTrigger("SlamR");
        yield return new WaitForSeconds(attackDelayTime);
        hitRCollider.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        hitRCollider.SetActive(false);
        yield return new WaitForSeconds(attackSwitchTime);
        anim.SetTrigger("SlamL");
        yield return new WaitForSeconds(attackDelayTime);
        hitLCollider.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        hitLCollider.SetActive(false);
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


    IEnumerator BossTimer()
    {
        if (!bossIsWeak)
        {
            yield return new WaitForSeconds(1);
            bossTimer--;
            StartCoroutine(BossTimer());
        }
    }




}
