using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonScript : MonoBehaviour
{
    void Start()
    {
        if (SaveManager.instance.hasLoaded)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
