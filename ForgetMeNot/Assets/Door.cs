using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public LevelLoader loader;
    int index;

    void Start()
    {
        index = transform.GetSiblingIndex();
        
    }

    void OnMouseDown()
    {
        loader.LoadRoom(index + 2);
    }

}
