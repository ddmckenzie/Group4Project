using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector3 respawnPoint;

    public float health;

    public List<GameObject> inventory;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //respawnPoint = player's position

        if (SaveManager.instance.hasLoaded)
        {
            respawnPoint = SaveManager.instance.activeSave.respawnPosition;
            //Change player's position to that point

            health = SaveManager.instance.activeSave.health;

            inventory = SaveManager.instance.activeSave.inventory;
        }
        else
        {
            SaveManager.instance.activeSave.health = health;
            SaveManager.instance.activeSave.inventory = inventory;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
