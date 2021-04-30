using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    void Start()
    {
        SaveManager.instance.DeleteSaveData();
    }
}
