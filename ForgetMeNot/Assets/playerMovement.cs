﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 3f;
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
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f; 
        }
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * z + transform.forward * x;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);       
        }
        
        velocity.y += gravity * Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);

    }
}
