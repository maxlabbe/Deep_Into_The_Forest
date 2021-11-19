using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool m_isGrounded;


    // Update is called once per frame
    void Update()
    {
        m_isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        animator.SetBool("isGrounded", m_isGrounded);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(x == 0f && z == 0f)
        {
            animator.SetBool("doNothing", true);
        }

        else
        {
            animator.SetBool("doNothing", false);
        }

        animator.SetFloat("moveHorizontaly", x);
        animator.SetFloat("moveVerticaly", z);
    }
}
