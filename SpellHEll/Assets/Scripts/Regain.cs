using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regain : MonoBehaviour
{
    public float mana;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("OnCollisionEnter2d");
            other.gameObject.GetComponent<Shooting>().ManaGain(mana);
            Destroy(gameObject);

        }
    }

}
