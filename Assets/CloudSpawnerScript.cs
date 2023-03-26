using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{

    public GameObject cloud;
    public float cloudSpawnRate = 5;
    private float cloudTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (cloudTimer < cloudSpawnRate)
        {
            cloudTimer = cloudTimer + Time.deltaTime;
            Debug.Log(cloudTimer);
        }
        else
        {
            spawnCloud();
            cloudTimer = 0;
        }
    }

    void spawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
