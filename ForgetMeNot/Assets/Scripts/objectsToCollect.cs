using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsToCollect : MonoBehaviour
{
    public Manager manager;
    public static int keys = 0;
    AudioSource keyAudio;
    // Start is called before the first frame update
    void Awake()
    {
        //keys++;
        keys=1;
    }

    void Start()
    {
        keyAudio = GameObject.Find("GameObject key").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnMouseDown()
    {
        if (gameObject.tag == "Key") {
            keys--;
            gameObject.SetActive(false);
            manager.foundKey();
            keyAudio.Play();
        }
    }
}
