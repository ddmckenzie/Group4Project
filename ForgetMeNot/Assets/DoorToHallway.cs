using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToHallway : MonoBehaviour
{
    public LevelLoader loader;

    void OnMouseDown()
    {
        loader.LoadRoom("Hallway");
    }
}
