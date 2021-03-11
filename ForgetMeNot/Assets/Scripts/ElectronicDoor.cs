using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectronicDoor : MonoBehaviour
{
    public LevelLoader loader;

    private void OnMouseDown()
    {
        loader.LoadHallway();
    }
}
