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

    public int levelProgress;

    public List<string> inventory;

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
            
        }
        else
        {
            SaveManager.instance.activeSave.health = health;

            SaveManager.instance.activeSave.levelProgress =  levelProgress;

            if (inventory.Count!=0)
            {
                foreach (string s in inventory)
                {
                    SaveManager.instance.activeSave.inventory.Add(s);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
