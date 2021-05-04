using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoorOpen : MonoBehaviour
{

    private bool DoorOpened;
    private Vector3 DoorStartPos;

    void Start()
    {
        DoorOpened = false;
        DoorStartPos = transform.position;
    }

    private void OnMouseDown()
    {
        if (SaveManager.instance.hasLoaded && SaveManager.instance.activeSave.inventory.Contains("Orb1"))
        {
            Invoke("Coroutine", 0f);
        }
            
    }
    private void Coroutine()
    {
        StartCoroutine("OpenDoor");
    }

    private IEnumerator OpenDoor()
    {
        if (!DoorOpened)
        {
            //Move door backwards
            for (float i = 0f; i <= 10f; i += 1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y,
                    transform.localPosition.z + 0.01f);

                yield return new WaitForSeconds(0f);
            }
            //Move door to the right
            for (float i = 0f; i <= 10f; i += 1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x + 0.2f,
                    transform.localPosition.y,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }

            DoorOpened = true; //Door is now open
        }

        else
        {
            //Move door to the left, back to its original x position
            for (float i = 0f; i <= 10f; i += 1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x - 0.2f,
                    transform.localPosition.y,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }
            //Move door forward, back to its original z position
            for (float i = 0f; i <= 10f; i += 1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y,
                    transform.localPosition.z - 0.01f);

                yield return new WaitForSeconds(0f);
            }

            transform.position = DoorStartPos;
            DoorOpened = false; // Door is closed
        }
    }
}
