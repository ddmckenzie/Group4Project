using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
    public string nextLevel;
    GameObject objUI;

    // Use this for initialization
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }
    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<Text>().text = objectsToCollect.objects.ToString() + " - Key to collect.";

        if (objectsToCollect.objects == 0)
        {
            objUI.GetComponent<Text>().text = "Bathroom Unlocked!";
        }

    }

 }
