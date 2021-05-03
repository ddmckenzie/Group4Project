using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float maxArmor = 50f;
    public float currentHealth;
    public float currentArmor;
    public bool gasOn;
    public Healthbar healthBar;
    public ArmorBar armorBar;

    void Start()
    {
        currentHealth = maxHealth/2;
        currentArmor = 0f;
        if (SaveManager.instance.hasLoaded)
        {
            currentHealth = SaveManager.instance.activeSave.health;
            currentArmor = SaveManager.instance.activeSave.armor;
        }
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        armorBar.SetMaxArmor(maxArmor);
        armorBar.SetArmor(currentArmor);

        gasOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        //currentHealth = healthBar.slider.value; // This is a temporary fix but is kinda buggy
        if (gasOn)
        {
            TakeDamage(0.01f);  
        }

        if (currentHealth<=0)
        {
            SceneManager.LoadScene("GameOVMenu");
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
        if (currentArmor > 0)
        {
            currentArmor -= damage;
            armorBar.SetArmor(currentArmor);
        }
        else
        {
            if (currentHealth > 0)
            {
                currentHealth -= damage;
                healthBar.SetHealth(currentHealth);
            }
        }
        SaveHealth();
        SaveArmor();
    }

    public void AddHealth(float health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
        SaveHealth();
    }

    public void AddArmor(float armor)
    {
        currentArmor += armor;
        armorBar.SetArmor(currentArmor);
        SaveArmor();
    }

    void SaveHealth()
    {
        GameManager.instance.health = currentHealth;
        SaveManager.instance.activeSave.health = currentHealth;
        SaveManager.instance.Save();

        Debug.Log("Saving health info");
    }

    void SaveArmor()
    {
        GameManager.instance.armor = currentArmor;
        SaveManager.instance.activeSave.armor = currentArmor;
        SaveManager.instance.Save();

        Debug.Log("Saving armor info");
    }
   
}
