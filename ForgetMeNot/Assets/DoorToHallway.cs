using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToHallway : MonoBehaviour
{
    public LevelLoader loader;
    AudioSource doorAudio;

    private void Start()
    {
       doorAudio = GameObject.Find("GameObject Main Door").GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        doorAudio.Play();
        loader.LoadRoom("Hallway");
        //doorAudio.Play();
    }
}
