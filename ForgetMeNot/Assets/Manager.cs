using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public ArrayList doorsUnlocked = new ArrayList();
    public Healthbar healthBar;

    public bool key;
    public bool screwdriver;
    public bool scienceId;
    public bool item1;
    public bool item2;
    public bool bedroomUnlocked;
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

        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);

    }

    public void foundKey()
    {
        key = true;
    }

    public void foundScrewDriver()
    {
        screwdriver = true;
    }

    public void foundScienceID()
    {
        scienceId = true;
        doorsUnlocked[3] = true;
    }

    public void foundItem1()
    {
        item1 = true;
        //Show item 2
        //release Gas and start timer
    }

    public void foundItem2()
    {
        item2 = true;
        doorsUnlocked[2] = true;
    }

    public void unlockStorageAndExit()
    {
        doorsUnlocked[4] = true;
        doorsUnlocked[5] = true;
    }
}
