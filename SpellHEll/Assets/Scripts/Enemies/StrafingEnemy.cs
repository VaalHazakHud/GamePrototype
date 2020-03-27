using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StrafingEnemy : BasicEnemyAI {

    private Vector2 startPosition;
    private Vector2 newPosition;


    //[SerializeField] private int speed = 3;
    [SerializeField] private int maxDistance = 1;

    void Start () {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update() {

        BasicFunctions();
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
            
    }

}
