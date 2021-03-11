using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    
    public Transform playerBody;
    
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f); //restricting the mouse look to 45 and negatice 45 degrees

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f); //allow user to rotate 360 degrees
        playerBody.Rotate(Vector3.up * mouseX); //allows user to rotate the cylinder with the camera 
    }
}