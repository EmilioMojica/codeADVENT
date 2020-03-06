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
    }

    IEnumerator dodajumping()
    {
        yield return new WaitForSeconds(5f);
        NEWstandingY = standingY;
    }

    void OnCollision(Collider other)
    {
        if (NEWstandingY == standingY)
        {
            thisRigidBody.AddForce(new Vector3(0, 3f, 0), ForceMode.Impulse);
            NEWstandingY = 0;
            //thisRigidBody.AddForce(0, 3f, 0);
            StartCoroutine(dodajumping());
        }
    }
}
