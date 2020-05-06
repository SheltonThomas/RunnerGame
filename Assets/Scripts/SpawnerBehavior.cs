using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform behaviorTarget;
    public float spawnInterval = 5;
    public float spawnRadius = 5;

    public float timeRemaining = 5;

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timeRemaining = spawnInterval;

            spawnObject();
        }
    }

    void spawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
        SeekBehavior seekBehavior = spawnedObject.GetComponent<SeekBehavior>();
        seekBehavior.target = behaviorTarget;
    }
}
