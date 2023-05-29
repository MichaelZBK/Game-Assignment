using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private Animator animator;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
        Cursor.visible = false;

        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40f, 52f);

        // rotate cam and orienation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);


        

        if (Input.GetKey(KeyCode.Mouse1))
        {
            animator.SetBool("Zoom", true);
        }
        else
        {
            animator.SetBool("Zoom", false);
        }
    }

}
