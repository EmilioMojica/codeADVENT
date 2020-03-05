using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VolumeZone : MonoBehaviour
{
    [Header("Tenant?")]
    public bool Entered;
    public bool Vacant;
    [Header("Who is Here?")]
    public List<string> Entities;
    public List<string> Elements;

    private void Start()
    {
        Vacant = true;
    }

    private void Update()
    {
        if (Entered == true && Vacant == true)
        {
            Vacant = true;
            Entered = false;
        }
        else if (Vacant == false && Entered == false)
        {
            Entered = true;
            Vacant = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Stats>())
        {
            Debug.Log("An Entity Has Entered!");
            Entities.Add(other.GetComponent<Transform>().name);
        }
        else
        {
            Elements.Add(other.GetComponent<Transform>().name);
        }

        if (Entered == true && Vacant == true)
        {
            Vacant = false;
        }
        Entered = true;
        Vacant = false;
    }

    private void OnTriggerStay(Collider other)
    {
        Vacant = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Stats>())
        {
            Debug.Log("An Entity Has Entered!");
            Entities.Remove(other.GetComponent<Transform>().name);
        }
        else
        {
            Elements.Remove(other.GetComponent<Transform>().name);
        }

        if (Vacant == true && Entered == true)
        {
            Entered = false;
        }
        Vacant = true;

    }
}
