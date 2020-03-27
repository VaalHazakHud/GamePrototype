using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CirclingEnemy : BasicEnemyAI
{
    
    public float diameter;
    public float RotateSpeed;

    //private CirclingEnemy;
    private Vector2 targetPosition;
    public Transform mTrans;
    public GameObject goToRotate;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //inst = this;
        mTrans = goToRotate.transform;
        //targetPosition = target.transform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        mTrans.LookAt(target.transform);
        
    }

    // Update is called once per frame
    void Update()
    {               
        transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        transform.Translate(diameter, 0, 0);
        transform.Rotate(0, 0, RotateSpeed);
    }
}
