using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Variables in SaveData
    public static GameManager instance;

    public Vector3 respawnPoint;

    public float health;

    public float armor;

    public int levelProgress;

    public List<string> inventory;

    public List<int> unlockedDoors;

    public bool gasOn;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        respawnPoint = new Vector3(0,0,0); //Needs to be changed to the player's position

        if (SaveManager.instance.hasLoaded)
        {
            //Respwaning position
            respawnPoint = SaveManager.instance.activeSave.respawnPosition;
            //Change player's position to that point

            //Player health
            health = SaveManager.instance.activeSave.health;

            //Player armor
            armor = SaveManager.instance.activeSave.armor;

            //Level Progression
            levelProgress = SaveManager.instance.activeSave.levelProgress;

            //Inventory
            if (SaveManager.instance.activeSave.inventory.Count!=0)
            {
                foreach (string s in SaveManager.instance.activeSave.inventory)
                {
                    inventory.Add(s);
                }
            }

            //Unlocked doors
            if (SaveManager.instance.activeSave.unlockedDoors.Count != 0)
            {
                foreach (int d in SaveManager.instance.activeSave.unlockedDoors)
                {
                    unlockedDoors.Add(d);
                }
            }

            //Gas On
            gasOn = SaveManager.instance.activeSave.gasOn;
        }
        else
        {
            //Health
            SaveManager.instance.activeSave.health = health;

            //Armor
            SaveManager.instance.activeSave.armor = armor;

            //Level Progress
            SaveManager.instance.activeSave.levelProgress =  levelProgress;

            //Inventory
            if (inventory.Count!=0)
            {
                foreach (string s in inventory)
                {
                    SaveManager.instance.activeSave.inventory.Add(s);
                }
            }

            //Unlocked Doors
            if (unlockedDoors.Count != 0)
            {
                foreach (int d in unlockedDoors)
                {
                    SaveManager.instance.activeSave.unlockedDoors.Add(d);
                }
            }

            //Gas On
            SaveManager.instance.activeSave.gasOn = gasOn;

        }
    }

}
