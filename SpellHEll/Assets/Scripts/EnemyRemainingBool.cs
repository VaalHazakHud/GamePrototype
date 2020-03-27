using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRemainingBool : MonoBehaviour {


    public GameObject Portal;
    public GameObject Player;    
    public bool mobs;
    GameObject[] enemies;
    

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        enemies = GameObject.FindGameObjectsWithTag("Baddie");

        if (enemies.Length != 0) {
            mobs = true;
            
        }

        else {
            mobs = false;            
        }

    }
    
    public void OnTriggerStay2D(Collider2D other) {
        

        if (enemies.Length == 0 && other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {

            Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
        }
    }

    }


