using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNoImpulse : MonoBehaviour
{
    [SerializeField]
    private int damage;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        col.gameObject.GetComponent<HealthSystem>().Damage(damage);
    }
}
