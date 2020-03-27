using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public GameObject Portal;
    public GameObject Player;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)){
            
            Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
            
        }
    }
    
}