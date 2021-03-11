using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 0.25f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        // checks to make sure object is on the ground
        // if it isnt it applies gravity at -2
        isGrounded = Physics.CheckSphere(groundCheck.position ,groundDistance, groundMask);
        
        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f; 
        }
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * z + transform.forward * x;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded) { // makes sure object is on the ground and gets input for the jump 
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);       
        }
        
        velocity.y += gravity * Time.deltaTime; // applies gravity to the object
        
        controller.Move(velocity * Time.deltaTime);

    }
}
