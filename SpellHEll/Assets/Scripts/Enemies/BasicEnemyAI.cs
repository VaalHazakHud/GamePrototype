using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour { 


    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    protected Rigidbody2D rb;
    

    protected Transform player;
    private Vector3 startingPosition;
    

    // Start is called before the first frame update
    private void Start()    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();

    }

    void Update ()    {

        BasicFunctions();   
    }

    public void BasicFunctions() {

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance) {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        else if (Vector2.Distance(transform.position, player.position) <
            stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance) {
            transform.position = this.transform.position;
        }

        else if (Vector2.Distance(transform.position, player.position) < retreatDistance) {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        Vector2 lookDir = player.GetComponent<Rigidbody2D>().position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }

}    
