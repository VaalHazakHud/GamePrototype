using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int heal;

    
    void OnTriggerEnter2D(Collider2D other)
    {               
        if (other.gameObject.tag == "Player")
            {
            Debug.Log("OnCollisionEnter2d");
            other.gameObject.GetComponent<HealthSystem>().Heal(heal);
            Destroy(gameObject);

        }
    }

}
