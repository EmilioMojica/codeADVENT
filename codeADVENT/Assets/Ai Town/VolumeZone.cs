//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public class VolumeZone : MonoBehaviour
//{
//    [Header("UponEntrance")]
//    [SerializeField] GameObject VolEntity;

//    [Header("Booleans")]
//    [SerializeField] bool VolEnter;
//    [SerializeField] bool VolExit;

//    [Header("Volume")]
//    public GameObject volume;
//    public float a;
//    public float VolAmount;

//    [Header("Additive Colors")]
//    public Material redplus;
//    public Material blueplus;
//    public Material yellowplus;
//    public Material greenplus;
//    public Material magentaplus;
//    public Material orangeplus;

//    [Header("Subtractive Colors")]
//    public Material redminus;
//    public Material blueminus;
//    public Material yellowminus;
//    public Material greenminus;
//    public Material magentaminus;
//    public Material orangeminus;

//    [Header("Health Volume")]
//    [SerializeField] public bool HPsub;
//    [SerializeField] public bool HPadd;

//    [Header("Mana Volume")]
//    [SerializeField] public bool MPsub;
//    [SerializeField] public bool MPadd;

//    [Header("Stamina Volume")]
//    [SerializeField] public bool SPsub;
//    [SerializeField] public bool SPadd;

//    [Header("Hunger Volume")]
//    [SerializeField] public bool HGRPsub;
//    [SerializeField] public bool HGRPadd;

//    [Header("Morale Volume")]
//    [SerializeField] public bool MRLPsub;
//    [SerializeField] public bool MRLPadd;

//    [Header("InternalClock Volume")]
//    [SerializeField] public bool ICPsub;
//    [SerializeField] public bool ICPadd;

//    // Awake
//    void Awake()
//    {
        
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//        volume = gameObject;
//        VolumeTypeSearch();
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void VolumeTypeSearch()
//    {
//        if (HPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = redplus;

//            if (VolEnter == true)
//            {
                
//                HealthPointsGive();
//            }
//        }
//        else if (MPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = blueplus;
//        }
//        else if (HGRPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = greenplus;
//        }
//        else if (SPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = yellowplus;
//        }
//        else if (MRLPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = magentaplus;
//        }
//        else if (ICPadd == true)
//        {
//            volume.GetComponent<Renderer>().material = orangeplus;
//        }
//        else if (HPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = redminus;
//        }
//        else if (MPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = blueminus;
//        }
//        else if (HGRPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = greenminus;
//        }
//        else if (SPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = yellowminus;
//        }
//        else if (MRLPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = magentaminus;
//        }
//        else if (ICPsub == true)
//        {
//            volume.GetComponent<Renderer>().material = orangeminus;
//        }
//    }

//    public void LabelEntity()
//    {
        
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other == VolEntity)
//        {
//            VolEnter = true;
//        }
//    }

//    public void HealthPointsGove()
//    {
        
//    }
//    public void HealthPointsTake()
//    {

//    }

//    public void ManaPointsGive()
//    {

//    }
//    public void ManaPointsTake()
//    {

//    }

//    public void StaminaPointsGive()
//    {

//    }
//    public void StaminaPointsTake()
//    {

//    }

//    public void HungerPointsGive()
//    {

//    }
//    public void HungerPointsTake()
//    {

//    }

//    public void MoralePointsGive()
//    {

//    }
//    public void MoralePointsTake()
//    {

//    }

//    public void InternalClockGive()
//    {

//    }
//    public void InternalClockTake()
//    {

//    }
//}
