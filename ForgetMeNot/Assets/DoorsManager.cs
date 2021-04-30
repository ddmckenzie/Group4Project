using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Keeps track of game progress in order to unlock certain doors

public class DoorsManager : MonoBehaviour
{
    int doorsUnlocked;

    //Enables the box colliders for the doors based on the progress number in PlayerPrefs
    void Awake()
    {
        doorsUnlocked = 0;
        if (SaveManager.instance.hasLoaded)
        {
            doorsUnlocked = SaveManager.instance.activeSave.levelProgress;
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
                Debug.Log("Office Unlocked");
                break;

            case 2:
                transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
                transform.GetChild(3).GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Office and Lab Unlocked");
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
        }

    }

    //Resets the doors to all be locked
    public void resetProgress()
    {
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
        PlayerPrefs.DeleteAll();
    }
}
