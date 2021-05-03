using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorManagement : MonoBehaviour
{
    void Start()
    {
        //Locks door by default
        gameObject.GetComponent<BoxCollider>().enabled = false;
        transform.Find("LockImage").gameObject.SetActive(true);
        //Checks if door is unlocked before unlocking it
        if (SaveManager.instance.hasLoaded && SaveManager.instance.activeSave.unlockedDoors.Contains(0))
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            transform.Find("LockImage").gameObject.SetActive(false);
            Debug.Log("The bedroom door is unlocked");
        }
        
    }
}
