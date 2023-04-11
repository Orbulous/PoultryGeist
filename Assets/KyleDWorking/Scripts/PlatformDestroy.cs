using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(DestroyPlat());
            
        }
        
    }

    IEnumerator DestroyPlat()
    {
         yield return new WaitForSeconds(1.5f);
         
        Destroy(gameObject);
    }

}
