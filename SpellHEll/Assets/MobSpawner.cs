using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public GameObject Monster;
   


    public void Spawn()
    {
        GameObject monster = Instantiate(Monster, transform.position, Quaternion.identity);

    }

    // Update is called once per frame
 
}
