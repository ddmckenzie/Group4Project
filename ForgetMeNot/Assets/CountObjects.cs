using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
    public string nextLevel;
    GameObject objUI;
    private Animation Fade;

    // Use this for initialization
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
        Fade = objUI.GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        //objUI.GetComponent<Text>().text = ObjectsToCollect.objects.ToString() + " - Key to collect.";

        //if (ObjectsToCollect.objects == 0)
       // {
            //objUI.GetComponent<Text>().text = "Bathroom Unlocked!";
            //Fade.Play();
        //}

    }

}
