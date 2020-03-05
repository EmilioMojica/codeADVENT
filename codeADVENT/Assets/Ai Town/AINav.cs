using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINav : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform self;

    [SerializeField]
    private GameObject Sleep;
    [SerializeField]
    private Vector3 SleepCoord;

    [SerializeField]
    private GameObject Food;
    [SerializeField]
    private Vector3 FoodCoord;

    [SerializeField]
    private GameObject Interaction;
    [SerializeField]
    private Vector3 InteractionCoord;

    // Start is called before the first frame update
    void Start()
    {
        //self = gameObject.GetComponent<Stats>().Entity;
    }

    // Update is called once per frame
    void Update()
    {
        GrabObjects();
        GetCoordinates();
        TravelTo();
    }

    // *** Need A Better Way To Do This ***
    void GrabObjects()
    {
        self = gameObject.GetComponent<Stats>().Entity;
        agent = self.GetComponent<NavMeshAgent>();
        Sleep = GameObject.Find("Bed");
        Food = GameObject.Find("Cantine");
        Interaction = GameObject.Find("Recreational");
    }

    void GetCoordinates()
    {
        SleepCoord = Sleep.GetComponent<Transform>().position;
        FoodCoord = Food.GetComponent<Transform>().position;
        InteractionCoord = Interaction.GetComponent<Transform>().position;
    }

    void TravelTo()
    {
        if (self.GetComponent<Stats>().InternalClock < 30)
        {
            agent.SetDestination(SleepCoord);
        }
        if (self.GetComponent<Stats>().Hunger < 15)
        {
            agent.SetDestination(FoodCoord);
        }
        if (self.GetComponent<Stats>().Morale < 10)
        {
            agent.SetDestination(InteractionCoord);
        }
    }
}