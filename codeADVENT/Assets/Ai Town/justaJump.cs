// Script will be deleted, just doing some testing.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justaJump : MonoBehaviour
{
    [SerializeField] private Rigidbody thisRigidBody;
    [SerializeField] private Transform meeee;
    [SerializeField] private float standingY;
    [SerializeField] private float NEWstandingY;
    [SerializeField] private bool JUMPA;

    // Start is called before the first frame update
    void Start()
    {
        meeee = GetComponent<Transform>();
        thisRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        standingY = meeee.transform.position.y;
        JumpChk();
    }

    IEnumerator dodajumping()
    {
        yield return new WaitForSeconds(3f);
        StartCoroutine(whereamI());
    }
    
    IEnumerator whereamI()
    {
        yield return new WaitForSeconds(3f);
        NEWstandingY = meeee.transform.position.y;
    }

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(dodajumping());
    }

    void JumpChk()
    {
        if (JUMPA == true)
        {
            thisRigidBody.AddForce(new Vector3(0, 1f, 0), ForceMode.Impulse);
        }
    }
}
