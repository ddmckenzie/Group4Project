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
