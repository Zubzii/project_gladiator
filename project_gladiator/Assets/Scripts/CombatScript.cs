using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombatScript : MonoBehaviour
{
    public bool attack;
    private Rigidbody playerRigidBody;
    Animator animator;
    SwordDamage swordDamage;
    GameObject sword;
    Collider swordCollider;

    private void Awake()
    {
        sword = GameObject.Find("MeleeWarriorSword");
        swordDamage = sword.GetComponent<SwordDamage>();
        swordCollider = sword.GetComponent<Collider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        animator = playerRigidBody.GetComponent<Animator>();
        swordCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        attack = Input.GetButtonDown("Attack");

        if (attack == true)
        {
            animator.SetBool("isAttacking", true);
        }
        else { animator.SetBool("isAttacking", false); }
    }

    public void CanAttack()
    {
        swordCollider.enabled = true;
    }

    public void CanNotAttack()
    {
        swordCollider.enabled = false;
    }
}
