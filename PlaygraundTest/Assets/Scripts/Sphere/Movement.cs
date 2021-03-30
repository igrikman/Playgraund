using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform grounCheck;
    public LayerMask groundMask;

    public float speed = 10f;

    public float gravity = -9.8f;

    Vector3 velocity;

    bool isGround;

    public float groundDistance = 0.2f;
  
    void Update()
    {
        isGround = Physics.CheckSphere(grounCheck.position, groundDistance, groundMask);
        if(isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
