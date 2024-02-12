using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Sound
{
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float groundDistance = 0.4f;

    Vector3 velocity;

    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if(Input.GetKey(KeyCode.W) || 
           Input.GetKey(KeyCode.A) || 
           Input.GetKey(KeyCode.S) || 
           Input.GetKey(KeyCode.D))
        {
            if (!audioSource.isPlaying)
            {
                PlayFootstepSound();
            }       
        }    
    }
}
