using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This code visually shows whether doors are locked with a padlock icon

public class DoorLockScript : MonoBehaviour
{
    bool isUnlocked; 

    //If box collider is enabled, deactivate the lock icon
    //If the boc collider is not enabled, activate the lock icon
    //If no box collider exists, destroy the lock icon
    void Start()
    {
        if (GetComponent<BoxCollider>() == true)
        {
            isUnlocked = GetComponent<BoxCollider>().enabled;

            if (isUnlocked == true)
            {
                transform.Find("LockImage").gameObject.SetActive(false);
            }
            else
            {
                transform.Find("LockImage").gameObject.SetActive(true);
            }
        }
        else
        {
            Destroy(transform.Find("LockImage").gameObject);
        }
    }

    
}
