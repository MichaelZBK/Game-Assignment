using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimations : MonoBehaviour
{
    private Animator animator; 

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Shoot", false);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Forward", true);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Back", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Back", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", true);
            animator.SetBool("Back", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
            animator.SetBool("Back", false);
        } else
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Back", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("Shoot", true);
        }
    }
}
