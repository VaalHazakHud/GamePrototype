using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallNoImpulse : MonoBehaviour
{
    [SerializeField]
    public GameObject hitEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);


        Destroy(effect, 1f);
        Destroy(gameObject);

    }

}


