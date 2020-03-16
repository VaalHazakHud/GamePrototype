using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    // list of bullet effects or "weapons"
    public GameObject ActiveProjectile;
    public GameObject OtherProjectile;
    private GameObject temp;
     
     
    public float bulletForce = 20f;


    void Update()

    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetMouseButtonDown(1))
        {
            temp = ActiveProjectile;
            ActiveProjectile = OtherProjectile;
            OtherProjectile = temp;
        }
        

    }

    void Shoot()
    {

            GameObject Bullet = Instantiate(ActiveProjectile, firePoint.position, firePoint.rotation);
            Debug.Log(transform.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
 

    }

}
