using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody myRigidBody;

    [SerializeField] float thrustPower = 1;
    [SerializeField] float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            myRigidBody.AddRelativeForce(Vector3.up * thrustPower * Time.deltaTime);
        }
    }

    private void ProcessRotation()
    {
         if(Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(-rotationSpeed);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(rotationSpeed);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        myRigidBody.freezeRotation = true; // freezing rotation so we can manually rotate
        transform.Rotate(0, 0, rotationThisFrame * Time.deltaTime);
        myRigidBody.freezeRotation = false;
    }
}
