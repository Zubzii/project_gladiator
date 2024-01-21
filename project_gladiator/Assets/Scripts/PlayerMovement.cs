using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveController: MonoBehaviour
{

    private Rigidbody playerRigidBody;
    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        transform.position = new Vector3(25f, 9f, 0f);
        
    }
    
    void Update()
    {
        
        bool rightInput = Input.GetButton("Right");
        bool leftInput = Input.GetButton("Left");
        Vector3 leftSpeed = new Vector3(0,0,-5);
        Vector3 rightSpeed = new Vector3(0,0,5);
        
        Animator animator = playerRigidBody.GetComponent<Animator>();

        if (rightInput == true)
        {
            playerRigidBody.transform.Translate(rightSpeed*Time.deltaTime);
            animator.SetBool("isWalkingRight", true);

        }
        else if (leftInput == true)
        {
            playerRigidBody.transform.Translate(leftSpeed * Time.deltaTime);
            animator.SetBool("isWalkingLeft", true);
        }
        else
        {
            animator.SetBool("isWalkingRight", false);
            animator.SetBool("isWalkingLeft", false);
        }

    }

}


