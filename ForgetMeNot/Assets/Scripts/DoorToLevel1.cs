using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToLevel1 : MonoBehaviour
{
    public LevelLoader loader;

    private void OnMouseDown()
    {
        loader.LoadRoom1();
    }
}
