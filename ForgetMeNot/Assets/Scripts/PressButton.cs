using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    Vector3 StartPos;
    public bool isPressed;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        isPressed = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        StartCoroutine("Press");
    }

    private IEnumerator Press()
    {
        if (!isPressed && count == 0)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.05f, transform.localPosition.z);
            count++;
        }
        isPressed = true;
        yield return new WaitForSeconds(0f);
    }
}
