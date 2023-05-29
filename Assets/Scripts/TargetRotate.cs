using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotate : MonoBehaviour
{
    public Transform cam;

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.transform.position + cam.transform.forward * 5f;
        transform.rotation = new Quaternion(0f, cam.transform.eulerAngles.x, 0f, 0f);
    }
}
