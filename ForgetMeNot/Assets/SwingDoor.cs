using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingDoor : MonoBehaviour
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
            for (float i = 0f; i <= 0.9f; i += 0.03f)
            {
                transform.Rotate(new Vector3(0f, 0f, transform.localPosition.z), 3f);

                yield return new WaitForSeconds(0f);
            }

            DoorOpened = true;
        }

        else
        {
            for (float i = 0.9f; i >= 0f; i -= 0.03f)
            {
                transform.Rotate(new Vector3(0f, 0f, transform.localPosition.z), -3f);

                yield return new WaitForSeconds(0f);
            }

            transform.position = DoorStartPos;
            DoorOpened = false;
        }
    }
}

