using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsToCollect : MonoBehaviour
{
    public static int keys = 0;
    AudioSource keyAudio;
    // Start is called before the first frame update
    void Awake()
    {
        keys=1;
    }

    void Start()
    {
        if (SaveManager.instance.hasLoaded)
        {
            if (SaveManager.instance.activeSave.inventory.Contains(gameObject.name))
            {
                keys = 0;
                Destroy(gameObject);
            }
        }
        keyAudio = GameObject.Find("GameObject key").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnMouseDown()
    {
        if (gameObject.tag == "Key") {
            keys--;
            gameObject.SetActive(false);
            keyAudio.Play();

            GameManager.instance.inventory.Add(gameObject.name);
            SaveManager.instance.activeSave.inventory.Add(gameObject.name);
            SaveManager.instance.Save();

            Debug.Log("Object added to inventory");
        }
    }
}
