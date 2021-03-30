using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsToCollect : MonoBehaviour
{
    public static int objects = 0;
    // Start is called before the first frame update
    void Awake()
    {
        objects++;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (gameObject.tag == "Key") {
            objects--;
            gameObject.SetActive(false);
        }
    }
}
