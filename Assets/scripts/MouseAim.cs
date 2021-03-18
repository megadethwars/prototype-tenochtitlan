using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;
    public GameObject childcamera;
    Vector3 offset;

    public float smooth = 10.05f;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);
        childcamera.transform.Rotate(vertical,0,0);
        
        float desiredAngle = target.transform.eulerAngles.y;
        float desiredAngle2 = childcamera.transform.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredAngle2, desiredAngle, 0);
        Vector3 newposition = target.transform.position - (rotation * offset);

        transform.position = Vector3.Slerp(transform.position, newposition, smooth);

        //transform.LookAt(target.transform);
        transform.rotation = rotation;
    }
}
