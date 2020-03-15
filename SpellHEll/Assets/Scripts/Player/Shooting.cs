﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject FireBallPrefab;

    public float bulletForce = 20f;


    void Update()

    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    void Shoot()
    {
        GameObject FireBall = Instantiate(FireBallPrefab, firePoint.position, firePoint.rotation);
        Debug.Log(transform.rotation);
        Rigidbody2D rb = FireBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }

}
