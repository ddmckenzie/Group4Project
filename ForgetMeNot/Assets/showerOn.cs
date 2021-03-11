using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showerOn : MonoBehaviour
{

    //public GameObject knob;
    public GameObject fog;
    private bool isOn;
    private Vector3 fogStartPos;

    // Start is called before the first frame update
    void Start()
    {
        fog = GameObject.Find("MirrorFog");
        fogStartPos = fog.transform.position;
        isOn = false;
    }

    private void OnMouseDown()
    {
        Invoke("Coroutine", 0f);
    }

    private void Coroutine()
    {
        StartCoroutine("WaterOn");
    }

    private IEnumerator WaterOn()
    {
        if (!isOn)
        {
            //turn on water sounds

            //fade in plane over mirror over 20 seconds
            for (float f = 0f; f <= 0.1; f += 0.005f)
            {
                fog.transform.localPosition = new Vector3
                    (fog.transform.localPosition.x + 0.005f,
                    fog.transform.localPosition.y,
                    fog.transform.localPosition.z);
                yield return new WaitForSeconds(1f);
            }
            isOn = true;
        }

        else
        {
            //turn off water sounds

            isOn = false;
        }
    }

}
