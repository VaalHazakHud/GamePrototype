using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRemainingBool : MonoBehaviour {


    public GameObject Portal;
    public GameObject Player;    
    GameObject[] enemies;
    

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnTriggerStay2D(Collider2D other) {

        enemies = GameObject.FindGameObjectsWithTag("Baddie");
    
    
        if (enemies.Length <= 0 && other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {

            Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
        }

        else {

            Console.WriteLine("Defeat All Enemies To Progress!");
        }
    }

}


