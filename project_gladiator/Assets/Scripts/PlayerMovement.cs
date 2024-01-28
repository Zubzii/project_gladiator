using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{

    private Rigidbody playerRigidBody;
    Animator animator;
    [SerializeField] float walkModifier = 15;
    [SerializeField] float rollModifier = 50;

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
        if (jumpInput == true && isTouchingGround == true)
        {
            Vector3 jumpSpeed = new Vector3(0, 1 * jumpModifier, 0);
            playerRigidBody.AddForce(jumpSpeed);
        }

        bool rollInput = Input.GetButtonDown("Roll");
        if (rollInput == true && walkInput <= 0)
        {
            animator.SetBool("isRollingBack", true);
            playerRigidBody.MovePosition(playerRigidBody.position + walkSpeed * rollModifier * Time.deltaTime);
        }
        else if (rollInput == true && walkInput > 0)
        {
            animator.SetBool("isRollingForward", true);
            playerRigidBody.MovePosition(playerRigidBody.position + walkSpeed * rollModifier * Time.deltaTime);
        }
        else 
        { 
            animator.SetBool("isRollingForward", false);
            animator.SetBool("isRollingBack", false);
        }

        //else if (rollInput == true /*&& walkInput > 0*/)
        //{
        //    animator.SetBool("isRolling", true);
        //    playerRigidBody.MovePosition(playerRigidBody.position + walkSpeed * rollModifier * Time.deltaTime);
        //}
        //else { animator.SetBool("isRolling", false); }
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

        if (isTouchingGround == false)
        {
            Debug.Log("Not touching ground");
        }

    }

}


