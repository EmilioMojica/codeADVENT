using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject curSpawner;
    public GameObject Entity;

    [SerializeField] float curSpawnerX;
    [SerializeField] float curSpawnerY;
    [SerializeField] float curSpawnerZ;
    
    public float spawnTime = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetTransformPosition();
        Instantiate(Entity, new Vector3(curSpawnerX, curSpawnerY, curSpawnerZ), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetTransformPosition()
    {
        curSpawnerX = curSpawner.GetComponent<Transform>().position.x;
        curSpawnerY = curSpawner.GetComponent<Transform>().position.y;
        curSpawnerZ = curSpawner.GetComponent<Transform>().position.z;
    }
}
