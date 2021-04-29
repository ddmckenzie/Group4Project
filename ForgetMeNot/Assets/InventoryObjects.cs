using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : MonoBehaviour
{
    void Start()
    {
        if (SaveManager.instance.hasLoaded)
        {
            if (SaveManager.instance.activeSave.inventory.Contains(gameObject.name))
            {
                Destroy(gameObject);
            }
        }
    }

    void OnMouseDown()
    {
        if (!GameManager.instance.inventory.Contains(gameObject.name))
        {
            GameManager.instance.inventory.Add(gameObject.name);
            SaveManager.instance.activeSave.inventory.Add(gameObject.name);
            SaveManager.instance.Save();
        }
        
    }
}
