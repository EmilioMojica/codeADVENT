using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent AutoPathing;
    [SerializeField] private Transform Myself;
    [SerializeField] private Rigidbody thisRigidBody;
    [SerializeField] public float speed;

    // Start is called before the first frame update
    void Start()
    {
        AutoPathing = GetComponent<NavMeshAgent>();
        Myself = GetComponent<Transform>();
        thisRigidBody = GetComponent<Rigidbody>();
        AutoPathing.Stop(true);
    }

    // Update is called once per frame
    void Update()
    {
        MoveMe();
    }

    void MoveMe()
    {
        if (Input.GetKeyDown("w"))
        {
            thisRigidBody.AddForce(new Vector3(0, 0, 05));
        }
    }
}
