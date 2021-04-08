using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public LevelLoader loader;
    public Manager manager;

    void OnMouseDown()
    {
        int index = transform.GetSiblingIndex();
        //Debug.Log("Index is " + index);
        //if (manager.doorsUnlocked[index] == true)
        //{
        //    loader.LoadRoom(index + 2); //Removes mainmenu and hallway as a choice
        //}
        //else
        //{
        //Send message that door is locked
        //    Debug.Log("This door is locked");
        //}
        loader.LoadRoom(index + 2);
        
    }
}
