using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBot : MonoBehaviour
{
    public float lowerLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
