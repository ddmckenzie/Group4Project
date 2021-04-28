using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{

    private bool DoorOpened;
    private Vector3 DoorStartPos;
    AudioSource bathroomDoor_Audio;

    void Start()
    {
        DoorOpened = false;
        DoorStartPos = transform.position;
        bathroomDoor_Audio = GameObject.Find("GameObject bathroom door").GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (objectsToCollect.keys == 0)
        {
            Invoke("Coroutine", 0f);
            bathroomDoor_Audio.Play();
        }
        //bathroomDoor_Audio.Play();
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

