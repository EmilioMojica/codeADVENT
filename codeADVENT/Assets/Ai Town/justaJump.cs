// Script will be deleted, just doing some testing.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justaJump : MonoBehaviour
{
    [SerializeField] private Rigidbody thisRigidBody;
    [SerializeField] private Transform meeee;
    [SerializeField] private bool JumpRN;

    // Start is called before the first frame update
    void Start()
    {
        JumpRN = false;
        meeee = GetComponent<Transform>();
        thisRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        JUMPOMG();
    }

    IEnumerator dodajumping()
    {
        
        yield return new WaitForSeconds(5f);
        JumpRN = false;
    }

    void JUMPOMG()
    {
        if (JumpRN == true)
        {
            thisRigidBody.AddForce(0, 100, 0);
            StartCoroutine(dodajumping());
        }
    }
}
