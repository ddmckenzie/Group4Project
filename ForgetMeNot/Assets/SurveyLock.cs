using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveyLock : MonoBehaviour
{
    public GameObject door;

    void OnMouseDown()
    {
        if (SaveManager.instance.hasLoaded)
        {
            if (SaveManager.instance.activeSave.inventory.Contains("Orb1") && SaveManager.instance.activeSave.inventory.Contains("Orb2"))
            {
                //Adds door to unlocked doors if it hasn't already been added
                if (!SaveManager.instance.activeSave.unlockedDoors.Contains(2))
                {
                    GameManager.instance.unlockedDoors.Add(2); // 2 is index for survey door
                    SaveManager.instance.activeSave.unlockedDoors.Add(2);
                    SaveManager.instance.Save();

                    door.GetComponent<BoxCollider>().enabled = true; //unlocks door
                    door.transform.Find("LockImage").gameObject.SetActive(false); //removes lock image

                    Debug.Log("Survey room unlocked");

                }

                //The orbs show in the lock
                transform.Find("Orb1").gameObject.SetActive(true);
                transform.Find("Orb2").gameObject.SetActive(true);

            }
        }
    }
}
