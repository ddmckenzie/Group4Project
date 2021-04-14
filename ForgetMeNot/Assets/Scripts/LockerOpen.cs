using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerOpen : MonoBehaviour
{

    private bool DoorOpened;
    private Vector3 DoorStartPos;

    //When the scene loads the door is set to be closed by default, and its starting position is referenced
    void Start()
    {
        DoorOpened = false;
        DoorStartPos = transform.position;
    }

    private void OnMouseDown()
    {
        Invoke("Coroutine", 0f); //Do this when mouse is clicked on door
    }

    private void Coroutine()
    {
        StartCoroutine("OpenDoor");
    }

    private IEnumerator OpenDoor()
    {
        // if the door is closed, start rotating it clockwise
        if (!DoorOpened)
        {
            for (float i = 0f; i <= 0.9f; i += 0.03f)
            {
                transform.Rotate(new Vector3(0f, transform.localPosition.y, 0f), -3f);

                yield return new WaitForSeconds(0f);
            }

            DoorOpened = true;
        }
        // if door is opened, start rotating it counterclockwise until the door is back in the starting position
        else
        {
            for (float i = 0.9f; i >= 0f; i -= 0.03f)
            {
                transform.Rotate(new Vector3(0f, transform.localPosition.y, 0f), 3f);

                yield return new WaitForSeconds(0f);
            }

            // after the door is completely closed, reset the door back to the starting values
            transform.position = DoorStartPos;
            DoorOpened = false;
        }
    }
}
