using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Transform tr;
    Rigidbody rgb;

    public float velocity;
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        rgb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            tr.Translate(Vector3.forward * velocity*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tr.Translate(Vector3.back *velocity* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tr.Translate(Vector3.left * velocity * Time.deltaTime);
            //tr.Rotate(Vector3.up, -1);
           
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tr.Translate(Vector3.right * velocity * Time.deltaTime);
            //tr.Rotate(Vector3.up, 1);
        }


        if (Input.GetKey(KeyCode.Space)) {
            rgb.AddForce(0,5,0,ForceMode.Force);
        }
        
    }
}
