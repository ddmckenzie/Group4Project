using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public List<bool> doorsUnlocked = new List<bool>();
    //public Healthbar healthBar;

    public bool key;
    public bool screwdriver;
    public bool scienceId;
    public bool item1;
    public bool item2;
    public bool bedroomUnlocked = true;
    public bool officeUnlocked;
    public bool surveyUnlocked;
    public bool labUnlocked;
    public bool storageUnlocked;
    public bool exitUnlocked;

    public int maxHealth = 100;
    public int currentHealth = 50;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        doorsUnlocked.Add(bedroomUnlocked);
        doorsUnlocked.Add(officeUnlocked);
        doorsUnlocked.Add(surveyUnlocked);
        doorsUnlocked.Add(labUnlocked);
        doorsUnlocked.Add(storageUnlocked);
        doorsUnlocked.Add(exitUnlocked);

        //healthBar.SetMaxHealth(maxHealth);
        //healthBar.SetHealth(currentHealth);

    }

    public void foundKey()
    {
        key = true;
        Debug.Log("key found");
    }

    public void foundScrewDriver()
    {
        screwdriver = true;
        Debug.Log("screwdriver found");
    }

    
}
