using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public ArrayList doorsUnlocked = new ArrayList();

    bool scienceIdfound;
    bool item1Found;
    bool item2Found;
    bool bedroomUnlocked;
    bool officeUnlocked;
    bool surveyUnlocked;
    bool labUnlocked;
    bool storageUnlocked;
    bool exitUnlocked;

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        doorsUnlocked.Add(bedroomUnlocked);
        doorsUnlocked.Add(officeUnlocked);
        doorsUnlocked.Add(surveyUnlocked);
        doorsUnlocked.Add(labUnlocked);
        doorsUnlocked.Add(storageUnlocked);
        doorsUnlocked.Add(exitUnlocked);

    }

    void foundScienceID()
    {
        scienceIdfound = true;
        doorsUnlocked[3] = true;
    }

    void foundItem1()
    {
        item1Found = true;
        //Show item 2
        //release Gas and start timer
    }

    void foundItem2()
    {
        item2Found = true;
        doorsUnlocked[2] = true;
    }

    void unlockStorageAndExit()
    {
        doorsUnlocked[4] = true;
        doorsUnlocked[5] = true;
    }
}
