using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgain : MonoBehaviour
{
    public LevelLoader loader;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
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

            //If the bedroom has been unlocked, load hallway
            if (SaveManager.instance.activeSave.unlockedDoors.Contains(0))
            {
                loader.LoadRoom("Hallway");
            }
            else
            {
                loader.LoadRoom("Bedroom");
            }
        }
        else
        {
            loader.LoadRoom("Bedroom");
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
