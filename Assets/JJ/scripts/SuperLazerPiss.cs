using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperLazerPiss : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }
}
