using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDeskDrawer : MonoBehaviour
{

    private bool deskDrawerOpened;
    private Vector3 deskDrawerStartPos;

    void Start()
    {
        deskDrawerOpened = false;
        deskDrawerStartPos = transform.position;
    }

    private void OnMouseDown()
    {
        Invoke("Coroutine", 0f);
    }

    private void Coroutine()
    {
        StartCoroutine("Open");
    }

    private IEnumerator Open()
    {
        if (!deskDrawerOpened)
        {
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x + 0.1f,
                    transform.localPosition.y,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }

            deskDrawerOpened = true;
        }

        else
        {
            for (float i = 1f; i >= 0f; i -= 0.1f)
            {
                transform.localPosition = new Vector3
                    (transform.localPosition.x - 0.1f,
                    transform.localPosition.y,
                    transform.localPosition.z);

                yield return new WaitForSeconds(0f);
            }

            transform.position = deskDrawerStartPos;
            deskDrawerOpened = false;
        }
    }
}
