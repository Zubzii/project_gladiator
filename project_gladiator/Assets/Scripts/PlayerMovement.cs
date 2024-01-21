using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveController: MonoBehaviour
{
    void Update()
    {
        bool rightInput = Input.GetButton("Right");
        bool leftInput = Input.GetButton("Left");
        Vector3 leftSpeed = new Vector3(0,0,-5);
        Vector3 rightSpeed = new Vector3(0,0,5);
        Rigidbody playerRigidBody = GetComponent<Rigidbody>();
        Animator animator = playerRigidBody.GetComponent<Animator>();
        animator.SetBool ("isWalking",false);

        if (rightInput == true)
        {
            playerRigidBody.transform.Translate(rightSpeed*Time.deltaTime);
            animator.SetBool("isWalking", true);

        }
        else if (leftInput == true)
        {
            playerRigidBody.transform.Translate(leftSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }

}


