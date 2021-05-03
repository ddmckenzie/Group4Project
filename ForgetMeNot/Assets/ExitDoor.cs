using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public LevelLoader loader;

    void OnMouseDown()
    {
        //loader.LoadRoom(""); //Add the name of the cutscene it's supposed to go to

        Debug.Log("Exiting");
    }
}
