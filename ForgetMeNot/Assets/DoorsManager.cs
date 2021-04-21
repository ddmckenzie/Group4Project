using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsManager : MonoBehaviour
{
    int doorsUnlocked;

    void Start()
    {
        doorsUnlocked = PlayerPrefs.GetInt("DoorsUnlocked");
        transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Bedroom Unlocked");

        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
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
                    transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
                }
                Debug.Log("All rooms are unlocked");
                break;
        }

    }

    public void resetProgress()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
        }
        PlayerPrefs.DeleteAll();
    }
}
