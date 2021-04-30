using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPaper : MonoBehaviour
{
    public TextAsset textFile;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        if (textFile.text == "")
        {
            text = "Not important...";
        }
        else
        {
            text = textFile.text;
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
