//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class AIController : MonoBehaviour
//{
//    [SerializeField] private Transform ContSelf;
//    [SerializeField] private Rigidbody ContselfRigidbody;
//    [SerializeField] private NavMeshAgent ContAgent;
//    [SerializeField] private bool CanJump;

//    // Start is called before the first frame update
//    void Start()
//    {
//        CanJump = false;
//        ContSelf = gameObject.GetComponent<Stats>().Entity;
//        ContselfRigidbody = GetComponent<Rigidbody>();
//        ContAgent = GetComponent<NavMeshAgent>();

//        ContselfRigidbody.isKinematic = false;
//        ContselfRigidbody.useGravity = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        HopInPlace();
//    }

//    IEnumerator YoChillWithTheJumping()
//    {
//        yield return new WaitForSeconds(1f);
//        CanJump = false;
//        ContAgent.Resume();
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.GetComponent<VolumeZone>())
//        {
//            CanJump = true;
//        }
//        StartCoroutine(YoChillWithTheJumping());
//    }

//    void HopInPlace()
//    {
//        if (CanJump == true)
//        {
//            ContAgent.Stop(true);
//            Debug.Log("A jump is suppose to happen.");
//            ContselfRigidbody.AddForce(0, 400, 0);
//            Debug.Log("A jump should have been executed.");
//        }
//    }
//}
