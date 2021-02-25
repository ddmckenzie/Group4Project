
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDresserDrawers : MonoBehaviour
{

    private bool DrawerOpened;
    private Vector3 DrawerStartPos;

    void Start()
    {
        DrawerOpened = false;
        DrawerStartPos = transform.position;
    }

    private void OnMouseDown()
    {
        Invoke ("Coroutine", 0f);
    }

    private void Coroutine()
    {
        StartCoroutine ("OpenDrawer");
    }

    private IEnumerator OpenDrawer ()
    {
        if (!DrawerOpened)
        {
            for (float i = 0f; i <= 1f; i += 0.1f)
            { 
                transform.localPosition = new Vector3
                    (transform.localPosition.x ,
                    transform.localPosition.y - 0.1f,
                    transform.localPosition.z);
                
                yield return new WaitForSeconds(0f);
            }
            
            DrawerOpened = true;   
        }

        else
        {
            for (float i = 1f; i >= 0f; i -=0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x ,
                    transform.localPosition.y + 0.1f,
                    transform.localPosition.z);
    
                yield return new WaitForSeconds(0f);
            }

            transform.position = DrawerStartPos;
            DrawerOpened = false;
        }
    }
}
