using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner9000 : MonoBehaviour
{
    private void Start()
    {

        StartCoroutine("SpawnTimer");
    }
    public GameObject Monster;
    IEnumerator SpawnTimer()
    {
        for (; ; )
        {
            Spawn();
            yield return new WaitForSeconds(10.5f);
        }
    }

    void Spawn()
    {
        GameObject monster = Instantiate(Monster, transform.position, Quaternion.identity);
    }

}
