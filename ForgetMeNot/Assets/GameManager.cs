using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector3 respawnPoint;

    public float health;

    //public List<GameObject> inventory;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = new Vector3(0,0,0);

        if (SaveManager.instance.hasLoaded)
        {
            respawnPoint = SaveManager.instance.activeSave.respawnPosition;
            //Change player's position to that point

            health = SaveManager.instance.activeSave.health;

            //foreach (GameObject i in SaveManager.instance.activeSave.inventory)
            //{
            //    inventory.Add(i);
            //}
            
        }
        else
        {
            SaveManager.instance.activeSave.health = health;
            //foreach (GameObject i in inventory)
            //{
            //    SaveManager.instance.activeSave.inventory.Add(i);
            //}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
