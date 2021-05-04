using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameScript : MonoBehaviour
{
    public LevelLoader loader;
    public void NewGame()
    {
        SaveManager.instance.DeleteSaveData();
        loader.LoadRoom("Scene1");
    }

    public void Resume()
    {
        loader.LoadRoom("Bedroom");
    }
}
