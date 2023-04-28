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
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Boss");

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
        while (transform.position.x != spots[0].position.x)
        {
            Debug.Log("While active. Position: " + transform.position.x + " Spot Position: " + spots[0].position.x);

            transform.position = Vector2.MoveTowards(transform.position, new Vector2(spots[0].position.x, transform.position.y), speed * Time.deltaTime);
            yield return null;

        }
        
        if(transform.position.x == spots[0].position.x)
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

}
