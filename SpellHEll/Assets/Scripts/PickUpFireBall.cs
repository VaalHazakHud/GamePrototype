using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFireBall : MonoBehaviour
{
    
    public GameObject myProjectile;
    private GameObject mtemp;
    private SpriteRenderer thisSprite;

    private void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
        thisSprite.sprite = myProjectile.GetComponent<SpriteRenderer>().sprite;
        thisSprite.color = myProjectile.GetComponent<SpriteRenderer>().color;

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            mtemp = other.GetComponent<Shooting>().ActiveProjectile;
            other.GetComponent<Shooting>().ActiveProjectile = myProjectile;
            myProjectile = mtemp;
            thisSprite.sprite = myProjectile.GetComponent<SpriteRenderer>().sprite;
            thisSprite.color = myProjectile.GetComponent<SpriteRenderer>().color;


        }
        
    }
}