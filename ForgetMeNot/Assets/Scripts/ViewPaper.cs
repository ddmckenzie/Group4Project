using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPaper : MonoBehaviour
{
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        if (text == "")
        {
            text = "Not important...";
        }
    }

    public void OnMouseDown()
    {
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
