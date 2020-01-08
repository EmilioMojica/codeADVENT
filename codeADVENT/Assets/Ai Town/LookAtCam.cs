using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    public Transform Title;

    // Start is called before the first frame update
    void Start()
    {
        Title = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Title.LookAt(Camera.main.transform);
        Title.rotation = Quaternion.LookRotation(Title.position - Camera.main.transform.position);
    }
}
