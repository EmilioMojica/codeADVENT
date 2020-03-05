using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent AutoPathing;
    [SerializeField] private Transform Myself;
    [SerializeField] public float speed;

    // Start is called before the first frame update
    void Start()
    {
        AutoPathing = GetComponent<NavMeshAgent>();
        Myself = GetComponent<Stats>().Entity;
        AutoPathing.Stop(true);
    }

    // Update is called once per frame
    void Update()
    {
        MoveMe();
    }

    void MoveMe()
    {
        float hor = Input.GetAxis("Horiztonal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}
