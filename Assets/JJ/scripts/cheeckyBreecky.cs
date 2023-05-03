using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeckyBreecky : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bullet;
    public GameObject bulletSpawn;
    public float firerate = 1f;
    public bool canShoot = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)   && canShoot)
        {
            Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            canShoot = false;
            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(firerate);
        canShoot = true;
    }
}
