using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAccessCard : MonoBehaviour
{
    void OnMouseDown()
    {
        GameManager.instance.unlockedDoors.Add(3); // 3 is index for lab
        SaveManager.instance.activeSave.unlockedDoors.Add(3);
        SaveManager.instance.Save();

        Debug.Log("Lab door unlocked");
    }
}
