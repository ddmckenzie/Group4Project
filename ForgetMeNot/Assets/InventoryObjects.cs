using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);
        if (SaveManager.instance.hasLoaded)
        {
            if (SaveManager.instance.activeSave.inventory.Contains(gameObject.name))
            {
                gameObject.SetActive(false);
            }
        }
    }

    void OnMouseDown()
    {
        GameManager.instance.inventory.Add(gameObject.name);
        SaveManager.instance.activeSave.inventory.Add(gameObject.name);
        SaveManager.instance.Save();

        gameObject.SetActive(false);
        Debug.Log("Object added to inventory");
    }
}
