using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoorUp : MonoBehaviour
{

    private bool isOpened;
    private Vector3 DoorStart;

    void Start()
    {
        isOpened = false;
        DoorStart = transform.position;
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
        if (!isOpened)
        {
            for (float i = 0f; i <= 2f; i += 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y + 0.1f,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }

            isOpened = true;
        }

        else
        {
            for (float i = 0f; i <= 2f; i += 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x,
                    transform.localPosition.y - 0.1f,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }

            transform.position = DoorStart;
            isOpened = false;
        }
    }
}
