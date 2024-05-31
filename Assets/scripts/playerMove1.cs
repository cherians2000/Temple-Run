
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMove1 : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;
    CharacterController characterController;
    Vector3 moveVelocity;
    float turnVelocity;
    public Animator anim;
    AudioSource audioSource;
    public AudioSource jumpSfx;
    public GameObject player;
    private int dis;


    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        player.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        bool backward = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        bool left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        if (characterController.isGrounded)
        {
            // Set moveVelocity to move forward by default.
            moveVelocity = transform.forward * speed;
            dis = (int)Mathf.Round(player.transform.position.x);
            DistanceCalc.DisRun = (int)(dis - 953.45);

            // Adjust moveVelocity for backward movement.
            if (backward)
            {
                anim.SetBool("slide", true);
                characterController.height = 10;
                characterController.center = new Vector3(0, 5f, 0);
                audioSource.Play();
            }
            else
            {
                anim.SetBool("slide", false);
                characterController.height = 17;
                characterController.center = new Vector3(0, 8.5f, 0);
                audioSource.Pause();
            }


            // Check for left and right movement.
            if (left)
                turnVelocity = -rotationSpeed;
            else if (right)
                turnVelocity = rotationSpeed;
            else
                turnVelocity = 0;

            // Check for jump.
            if (Input.GetKey(KeyCode.Space))
            {
                moveVelocity.y = jumpSpeed;
                anim.SetBool("jump", true);
                jumpSfx.Play();
               


            }
            else
            {
                anim.SetBool("jump", false);
                jumpSfx.Stop();
            }
        }
        else
        {
            // Apply gravity when not grounded.
            moveVelocity.y += gravity * Time.deltaTime;
        }

        characterController.Move(moveVelocity * Time.deltaTime);

        // Rotate based on turnVelocity.
        transform.Rotate(Vector3.up * turnVelocity * Time.deltaTime);
    }
}