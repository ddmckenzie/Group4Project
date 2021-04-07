using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsToCollect : MonoBehaviour
{
    public static int keys = 0;
    // Start is called before the first frame update
    void Awake()
    {
        keys++;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (gameObject.tag == "Key") {
            keys--;
            gameObject.SetActive(false);
        }
    }
}
