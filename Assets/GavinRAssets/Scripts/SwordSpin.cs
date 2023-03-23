using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSpin : MonoBehaviour
{
    public GameObject sword;

    public float rotateSpeed;


    // Start is called before the first frame update
    void Start()
    {
        sword = GameObject.Find("Sword");


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        

    }
}
