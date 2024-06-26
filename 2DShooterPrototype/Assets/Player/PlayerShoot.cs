using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform bulletSpanwPoint;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletSpanwPoint.position, bulletSpanwPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpanwPoint.up;
        }

    }
}
