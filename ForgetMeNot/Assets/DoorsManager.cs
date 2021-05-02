using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Keeps track of game progress in order to unlock certain doors

public class DoorsManager : MonoBehaviour
{
    //int doorsUnlocked;

    //Enables the box colliders for the doors based on the progress number in PlayerPrefs
    void Awake()
    {
        if (SaveManager.instance.hasLoaded)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (SaveManager.instance.activeSave.unlockedDoors.Contains(i))
                {
                    unlockDoor(i);
                }
                else
                {
                    lockDoor(i);
                }
            }
        }
        else
        {
            reset();
        }

        /*doorsUnlocked = 3;
        if (SaveManager.instance.hasLoaded)
        {
            doorsUnlocked = SaveManager.instance.activeSave.levelProgress;
        }
        else {
            GameManager.instance.levelProgress = doorsUnlocked;
            SaveManager.instance.activeSave.levelProgress = doorsUnlocked;
            SaveManager.instance.Save();
        }
        transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Bedroom Unlocked");

        for (int i = 1; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<BoxCollider>() == true)
            {
                transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
            }
            else
            {
                transform.GetChild(i).Find("Door").GetComponent<BoxCollider>().enabled = false;
            }
            
        }

        switch (doorsUnlocked)
        {
            case 1:
                transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
                transform.GetChild(4).Find("Door").GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Office and Storage Unlocked");
                break;

            case 2:
                transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
                transform.GetChild(3).GetComponent<BoxCollider>().enabled = true;
                transform.GetChild(4).Find("Door").GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Office, Lab, and Storage Unlocked");
                break;

            case 3:
                for (int i = 1; i < transform.childCount; i++)
                {
                    if (transform.GetChild(i).GetComponent<BoxCollider>() == true)
                    {
                        transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
                    }
                    else
                    {
                        transform.GetChild(i).Find("Door").GetComponent<BoxCollider>().enabled = true;
                    }

                }
                Debug.Log("All rooms are unlocked");
                break;
        }*/

    }

    //Unlocks door
    public void unlockDoor(int index)
    {
        if (transform.GetChild(index).GetComponent<BoxCollider>() == true)
        {
            transform.GetChild(index).GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            transform.GetChild(index).Find("Door").GetComponent<BoxCollider>().enabled = true;
        }
    }

    //Locks door
    public void lockDoor(int index)
    {
        if (transform.GetChild(index).GetComponent<BoxCollider>() == true)
        {
            transform.GetChild(index).GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            transform.GetChild(index).Find("Door").GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void reset()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            lockDoor(i);
        }
    }
}
