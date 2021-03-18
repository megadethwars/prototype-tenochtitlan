using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targeobject;
    public bool look;
    public Vector3 cameraoffset;

    public float smooth = 0.5f;
    void Start()
    {
        cameraoffset = transform.position - targeobject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = targeobject.transform.position + cameraoffset;
        transform.position = Vector3.Slerp(transform.position,newposition,smooth);

        if (look) {
            transform.LookAt(targeobject);
        }


    }
}
