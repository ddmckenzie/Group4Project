using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorManagement : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        if (SaveManager.instance.hasLoaded && SaveManager.instance.activeSave.unlockedDoors.Contains(0))
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            Debug.Log("The bedroom door is unlocked");
        }
        
    }
}
