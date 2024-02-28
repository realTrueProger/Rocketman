using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustSpeed = 1000f;
    [SerializeField] float rotateSpeed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Test commit");
        ProcessUp();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rotate(1);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Rotate(-1);
        }
    }

    private void Rotate(float modifier)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime * modifier);
        rb.freezeRotation = false;
    }

    void ProcessUp()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustSpeed * Time.deltaTime);
        }
    }
}
