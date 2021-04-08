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

    public void unlockBedroom()
    {
        doorsUnlocked[0] = true;
        Debug.Log("bedroom unlocked");
    }

    public void foundScienceID()
    {
        scienceId = true;
        doorsUnlocked[3] = true;
        Debug.Log("scienceID found");
        Debug.Log("lab unlocked");
    }

    public void foundItem1()
    {
        item1 = true;
        //Show item 2
        //release Gas and start timer
        Debug.Log("item 1 found");
        Debug.Log("item 2 available");
    }

    public void foundItem2()
    {
        item2 = true;
        doorsUnlocked[2] = true;
        Debug.Log("item 2 found");
        Debug.Log("survey room unlocked");
    }

    public void unlockStorageAndExit()
    {
        doorsUnlocked[4] = true;
        doorsUnlocked[5] = true;
        Debug.Log("storage unlocked");
        Debug.Log("exit unlocked");
    }
}
