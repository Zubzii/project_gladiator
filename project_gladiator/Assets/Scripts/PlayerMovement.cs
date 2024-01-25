using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{

    private Rigidbody playerRigidBody;
    Animator animator;
    [SerializeField] float walkModifier = 15;

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        transform.position = new Vector3(5f, 9f, 0f);
        animator = playerRigidBody.GetComponent<Animator>();
    }

    [SerializeField] float jumpModifier = 9000;
    bool isTouchingGround = true;

    void Update()
    {
        float walkInput = Input.GetAxis("Walk");
        Vector3 walkSpeed = new Vector3(0, 0, walkInput);

        playerRigidBody.MovePosition(playerRigidBody.position + walkSpeed * walkModifier * Time.deltaTime);

        animator.SetBool("isWalkingRight", walkSpeed.z > 0);
        animator.SetBool("isWalkingLeft", walkSpeed.z < 0);

        bool jumpInput = Input.GetButtonDown("Jump");
        Debug.Log(jumpInput);
        if (jumpInput == true && isTouchingGround == true)
        {
            Vector3 jumpSpeed = new Vector3(0, 1 * jumpModifier, 0);
            playerRigidBody.AddForce(jumpSpeed);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isTouchingGround = false;
            animator.SetBool("isJumping", true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isTouchingGround = true;
            animator.SetBool("isJumping", false);
        }
    }

}


