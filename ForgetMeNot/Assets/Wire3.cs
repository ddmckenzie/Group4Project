using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire3 : MonoBehaviour
{
    public GameObject door;

    void Start()
    {
        gameObject.SetActive(true);
        if (SaveManager.instance.hasLoaded)
        {
            if (SaveManager.instance.activeSave.unlockedDoors.Contains(0))
            {
                gameObject.SetActive(false);
            }
        }
    }

    void OnMouseDown()
    {
        if (SaveManager.instance.activeSave.inventory.Contains("ScrewDriver"))
        {
            GameManager.instance.unlockedDoors.Add(0); // 0 is index for bedroom door
            SaveManager.instance.activeSave.unlockedDoors.Add(0);
            SaveManager.instance.Save();

            door.GetComponent<BoxCollider>().enabled = true; //unlocks door
            door.transform.Find("LockImage").gameObject.SetActive(false); //removes lock image
            //Add dialogue script here

            gameObject.SetActive(false);

            Debug.Log("Bedroom unlocked");
        }
        else
        { 
            //Possibly add dialogue here
        }
    }
}
