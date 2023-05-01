using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene1.SetActive(false);
        scene2.SetActive(false);
        scene3.SetActive(false);
        scene4.SetActive(false);
    }
}
