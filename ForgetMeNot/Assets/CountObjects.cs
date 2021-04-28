using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
    public string nextLevel;
    GameObject objUI;
    private Animation Fade;

    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
        Fade = objUI.GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<Text>().text = "Find The Key";

        if (objectsToCollect.keys == 0)
        {
            objUI.GetComponent<Text>().text = "Bathroom Unlocked!";
            Fade.Play();
        }

    }

}
