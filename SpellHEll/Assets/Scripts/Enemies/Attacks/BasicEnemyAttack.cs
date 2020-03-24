using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAttack : MonoBehaviour{
    
    public float projectileSpeed;    
    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;    
    private Vector2 target;
    protected Rigidbody2D rb;
    protected Transform player;

    // Start is called before the first frame update
    void Start(){

        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update(){

        //BasicFunctions();                    

        if (timeBtwShots <= 0) {
            Shoot();
            timeBtwShots = startTimeBtwShots;             
        }

        else {
            timeBtwShots -= Time.deltaTime;
        }        
    }              

    void Shoot() {
        GameObject Bullet = Instantiate(projectile, transform.position + transform.up, Quaternion.identity);
        Debug.Log(transform.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * projectileSpeed, ForceMode2D.Impulse);
    }
}
