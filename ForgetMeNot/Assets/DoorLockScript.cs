using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This code visually shows whether doors are locked with a padlock icon

public class DoorLockScript : MonoBehaviour
{
    bool isUnlocked; 

    //If box collider is enabled, deactivate the lock icon
    //If the boc collider is not enabled, activate the lock icon
    //If no box collider exists, deactivate the lock icon
    void Start()
    {
        if (GetComponent<BoxCollider>() == true)
        {
            isUnlocked = GetComponent<BoxCollider>().enabled;
            setLockImage();
;            
        }
        else if (transform.Find("Door").GetComponent<BoxCollider>() == true)
        {
            isUnlocked = transform.Find("Door").GetComponent<BoxCollider>().enabled;
            setLockImage();
        }
        else
        {
            Destroy(transform.Find("LockImage").gameObject);
        }
    }

    //Activates or deactivates the lock icon
    void setLockImage()
    {
        if (isUnlocked == true)
        {
            transform.Find("LockImage").gameObject.SetActive(false);
        }
        else
        {
            transform.Find("LockImage").gameObject.SetActive(true);
        }
    }
}
