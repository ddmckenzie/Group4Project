using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public LevelLoader loader;

    void OnMouseDown()
    {
        loader.LoadRoom("EndScene1"); //Goes to the end cutscene

        Debug.Log("Exiting");
    }
}
