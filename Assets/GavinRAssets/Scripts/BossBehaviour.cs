using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] spots;
    public float speed;
    public float size;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Boss");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Boss()
    {
        //First Attack



        while (transform.position.x != spots[0].position.x)
        {
          
           transform.position = Vector2.MoveTowards(transform.position, new Vector2(spots[0].position.x, transform.position.y), speed* Time.deltaTime);

            

            yield return new WaitForSeconds(1f);
            
            yield return null;


        }
    }

}
