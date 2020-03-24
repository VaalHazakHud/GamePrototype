using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFireBall : MonoBehaviour
{
    
    public GameObject myWeapon;
    private GameObject mtemp;
    private SpriteRenderer thisSprite;

    private void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
        thisSprite.sprite = myWeapon.GetComponent<SpriteRenderer>().sprite;
        thisSprite.color = myWeapon.GetComponent<SpriteRenderer>().color;

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            mtemp = other.GetComponent<Shooting>().ActiveWeapon;
            other.GetComponent<Shooting>().ActiveWeapon = myWeapon;
            myWeapon = mtemp;
            thisSprite.sprite = myWeapon.GetComponent<SpriteRenderer>().sprite;
            thisSprite.color = myWeapon.GetComponent<SpriteRenderer>().color;


        }
        
    }
}