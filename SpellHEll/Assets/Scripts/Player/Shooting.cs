using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    // list of bullet effects or "weapons"
    public GameObject ActiveWeapon;
    public GameObject OtherWeapon;
    private GameObject temp;

    public ManaBar manaBar;

    public float manaMax = 200f;
    public float manaCost;
    public float mana;
    public float manaRegRate = 0.0f;
    public float regDelay = 0.0f;
     
    public float bulletForce = 20f;

    public bool canShoot;
    public float delay;

    public float timeBtwShots;
    public float timeBtwShotsOther;
    public float timeBtwShotsTemp;


    private void Start()
    {
        mana = manaMax;
        StartCoroutine("ManaRegenration");           

    }

    void Update()

    {
        if (timeBtwShots <= 0)
        {
            canShoot = true;
        }

        else
        {
            canShoot = false;
            timeBtwShots -= Time.deltaTime;
        }
        
        if (timeBtwShotsOther >= 0)
        {
            timeBtwShotsOther -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetMouseButtonDown(1))
        {
            temp = ActiveWeapon;
            ActiveWeapon = OtherWeapon;
            OtherWeapon = temp;

            timeBtwShotsTemp = timeBtwShots;
            timeBtwShots = timeBtwShotsOther;
            timeBtwShotsOther = timeBtwShotsTemp;

}

        manaBar.SetBarMana(mana);
        
        //regDelay = ActiveWeapon.GetComponent<FireControl>().CoolDown;
    }

    void Shoot()
    {
        manaCost = ActiveWeapon.GetComponent<FireControl>().AmmoCost;
        delay = ActiveWeapon.GetComponent<FireControl>().CoolDown;
        if (mana >= manaCost && canShoot == true)
        {
            GameObject Bullet = Instantiate(ActiveWeapon, firePoint.position, firePoint.rotation);
            Debug.Log(transform.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            ManaUsed(manaCost);
            timeBtwShots = delay;
        }
 

    }

    public void ManaUsed(float manaCost)
    {
        mana -= manaCost;
        if (mana < 0) mana = 0;
    }

    IEnumerator ManaRegenration()
    {
        while (true)
        {
            if (mana < manaMax)
                mana = (mana + manaRegRate);
            if (mana > manaMax) mana = manaMax;
            yield return new WaitForSeconds(regDelay);
        }
    }

}
