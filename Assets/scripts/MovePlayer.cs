using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    public float moveSpeed = 10;
    public float leftRightSpeed = 10;
    public float jumpForce = 10; // Adjust the jump force as needed.
    static public bool canMove = false;
    public static int disRun;
    public GameObject player;
    public Animator anim;
    public AudioSource jumpSfx;

    private bool isJumping = false;
    private Rigidbody rb; // Reference to the Rigidbody component.
    private CapsuleCollider capsuleCollider; // Reference to the CapsuleCollider component;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>(); // Get the CapsuleCollider component.
    }

    void Update()
    {
        disRun = Mathf.RoundToInt(player.transform.position.z);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
        {
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x >= boundary.leftside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x <= boundary.rightside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * -leftRightSpeed);
                }
            }

            // Check for jumping only when grounded.
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        if (rb != null)
        {
            // Apply an upward force to jump if a Rigidbody is attached.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetBool("jump", true);
            jumpSfx.Play();
            // Decrease the height of the CapsuleCollider during the jump.
            capsuleCollider.height = 0.5f;
            isJumping = true;
        }
    }

    // Detect when the player touches the ground.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Reset the isJumping flag and restore the CapsuleCollider height.
            isJumping = false;
            capsuleCollider.height = 1f;
            anim.SetBool("jump", false);
        }
    }
}
