using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgain : MonoBehaviour
{
    public LevelLoader loader;

    public void ResetCheckpoint()
    {
        //Resets health to 50 and armor to 0
        if (SaveManager.instance.hasLoaded)
        {
            GameManager.instance.health = 50;
            GameManager.instance.armor = 0;

            SaveManager.instance.activeSave.health = 50;
            SaveManager.instance.activeSave.armor = 0;

            SaveManager.instance.Save();

            Debug.Log("Reset health and armor");
        }

        //Loads Hallway
        loader.LoadRoom("Hallway");
    }
}
