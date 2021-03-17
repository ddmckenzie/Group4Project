using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public LevelLoader loader;

    void OnMouseDown()
    {
        int index = transform.GetSiblingIndex();
        loader.LoadRoom(index + 2); //Removes mainmenu and hallway as a choice
    }
}
