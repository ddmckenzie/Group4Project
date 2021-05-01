using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewPaper : MonoBehaviour
{
    public TextAsset textFile;
    public Text Textfield;
    public string text;
    private bool showText;
    private bool button;
    // Start is called before the first frame update
    void Start()
    {
        if (textFile == null)
        {
            text = "Not important...";
        }
        else
        {
            text = textFile.text;
        }
        showText = false;
    }

    public void OnMouseDown()
    {
        if (!showText)
        {
            Textfield.text = text + "\n PRESS C TO CLOSE";
            showText = true;
        }
        //Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Textfield.text = "";
            showText = false;
        }
    }
}
