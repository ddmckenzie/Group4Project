﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public bool gasOn;
    public Healthbar healthBar;

    void Start()
    {
        currentHealth = maxHealth/2;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        gasOn = false;

    }

    // Update is called once per frame
    void Update()
    {
        //currentHealth = healthBar.slider.value; // This is a temporary fix but is kinda buggy
        if (gasOn)
        {
            TakeDamage(0.1f);  
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hazard")
        {
            TakeDamage(0.4f);   
        }
        else if (other.tag == "DeathHazard")
        {
            TakeDamage(2f);
        }
    }


    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void AddHealth(float health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }
   
}
