using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public LevelLoader loader;
    public GameObject doors;
    int doorsUnlocked;

    void Start()
    {
        doorsUnlocked = PlayerPrefs.GetInt("DoorsUnlocked");
        doors = GameObject.Find("Doors");
        doors.transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Bedroom Unlocked");

        for (int i = 1; i < doors.transform.childCount; i++)
        {
            doors.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
        }

        switch (doorsUnlocked)
        {
            case 1:
                doors.transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Office Unlocked");
                break;

            case 2:
                doors.transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
                doors.transform.GetChild(3).GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Office and Lab Unlocked");
                break;

            case 3:
                for (int i = 1; i < doors.transform.childCount; i++)
                {
                    doors.transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
                }
                Debug.Log("All rooms are unlocked");
                break;
        }
        
    }

    void OnMouseDown()
    {
        int index = transform.GetSiblingIndex();
        
        loader.LoadRoom(index + 2);
        
    }

    public void resetProgress() {
        for (int i = 1; i < doors.transform.childCount; i++)
        {
            doors.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
        }
        PlayerPrefs.DeleteAll();
    }
}
