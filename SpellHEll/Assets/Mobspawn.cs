using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobspawn : MonoBehaviour
{
    public bool triggerOn;
    public bool spawnShoot;
    


    void Start()
    {
        triggerOn = true;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && triggerOn == true)
        {
            foreach(Transform child in gameObject.transform)
            {
                child.gameObject.GetComponent<MobSpawner>().Spawn();
            }
            triggerOn = false;
                       
        }
    }
}
