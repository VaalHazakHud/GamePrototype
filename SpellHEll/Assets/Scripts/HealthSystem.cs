﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthSystem : MonoBehaviour
{

    //public event UnityEvent OnHealthChanged;
    [SerializeField]
    private int health;
    [SerializeField]
    public int healthMax;
    [SerializeField]
    public GameObject deathEffect;

    public HealthBar healthBar;
    




    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
        healthBar.SetMaxHealth(healthMax);
    }

    public int GetHealth()
    {
        return health;
    }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;

    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;


        //if (OnHealthChanged != null) OnHealthChanged(healthBar.SetBarHealth(health));
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax) health = healthMax;
        //if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }

    void Update()
    {
        if (health == 0)
        {
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
        }



        healthBar.SetBarHealth(health);
    }
}
    
