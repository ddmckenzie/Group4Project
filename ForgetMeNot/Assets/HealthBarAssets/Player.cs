using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script based off tuturial by Brackeys
public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Healthbar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
