// Script will be deleted, just doing some testing.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justaJump : MonoBehaviour
{
    [SerializeField] private Rigidbody thisRigidBody;
    [SerializeField] float distToGround;
    [SerializeField] float addedf = 0.1f;
    [SerializeField] float positionY;
    [SerializeField] float GroundPos;
    //[SerializeField] float distToGroundTOUCH = distToGround + 0.1;
    [SerializeField] bool IsGrounded = false;
    [SerializeField] bool DoubleJump = false;
    [SerializeField] bool Floated = false;

    void Start()
    {
        thisRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        distToGround = GetComponent<Collider>().bounds.extents.y;
        positionY = GetComponent<Transform>().position.y;
        IfAirborne();
    }

    void IfAirborne()
    {
        if (!Physics.Raycast(transform.position, -Vector3.up, distToGround + addedf))
        {
            IsGrounded = false;
        }
        else
        {
            IsGrounded = true;
            DoubleJump = false;
            Floated = false;
            GroundPos = positionY;
            StartCoroutine(dodajumping());
            //JumpChk();
        }
    }

    IEnumerator dodajumping()
    {
        yield return new WaitForSeconds(0.5f);
        JumpChk();
    }

    void JumpChk()
    {
        if (IsGrounded = true)
        {
            if (Input.GetKeyDown("space"))
            {
                thisRigidBody.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
                StartCoroutine(doadoublejump());
            }
        }
    }

    IEnumerator doadoublejump()
    {
        yield return new WaitForSeconds(0.05f);
        DJumpChk();
    }

    void DJumpChk()
    {
        if (IsGrounded != true && Floated != true)
        {
            if (Input.GetKeyDown("space"))
            {
                thisRigidBody.AddForce(new Vector3(0, 0.05f, 0), ForceMode.Impulse);
                DoubleJump = true;
                StartCoroutine(doafloat());
            }
        }
    }

    IEnumerator doafloat()
    {
        yield return new WaitForSeconds(0.5f);
        FloatCheck();
        Floated = true;
        yield return new WaitForSeconds(0.2f);
        FloatCheck();
        yield return new WaitForSeconds(0.2f);
        FloatCheck();
        yield return new WaitForSeconds(0.2f);
        FloatCheck();
        Floated = false;
    }

    void FloatCheck()
    {
        if (IsGrounded != true && Floated != false)
        {
            if (Input.GetKeyDown("space"))
            {
                thisRigidBody.AddForce(new Vector3(0, 0.03f, 0), ForceMode.Impulse);
            }
        }
    }
}
