using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;
    CharacterController characterController;
    Vector3 moveVelocity;
    float turnVelocity;
    public static Animator anim;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Use GetKey instead of GetAxis for specific key presses.
        bool forward = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        bool backward = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        bool left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        if (characterController.isGrounded)
        {
            moveVelocity = Vector3.zero; // Reset move velocity.

            // Check for forward and backward movement.
            if (forward)
                moveVelocity += transform.forward * speed;
            else if (backward)

                moveVelocity -= transform.forward * speed;

            // Check for left and right movement.
            if (left)
                turnVelocity = -rotationSpeed;
            else if (right)
                turnVelocity = rotationSpeed;
            else
                turnVelocity = 0;

            if (Input.GetKey(KeyCode.Space))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);

        // Rotate based on turnVelocity.
        transform.Rotate(Vector3.up * turnVelocity * Time.deltaTime);
    }
}
