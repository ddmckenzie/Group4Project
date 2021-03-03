using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 85f, 0f) * Time.deltaTime);
    }
}
