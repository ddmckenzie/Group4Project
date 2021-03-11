using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
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
        Invoke("Coroutine", 0f);
    }

    private void Coroutine()
    {
        StartCoroutine("OpenDoor");
    }

    private IEnumerator OpenDoor()
    {
        if (!DoorOpened)
        {
            for (float i = 0f; i <= 0.8f; i += 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y,
                    transform.localPosition.z - 0.1f);

                yield return new WaitForSeconds(0f);
            }

            DoorOpened = true;
        }

        else
        {
            for (float i = 0f; i <= 0.8f; i += 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y,
                    transform.localPosition.z + 0.1f);

                yield return new WaitForSeconds(0f);
            }

            transform.position = DoorStartPos;
            DoorOpened = false;
        }
    }
}

