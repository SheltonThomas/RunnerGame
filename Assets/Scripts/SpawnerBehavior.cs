using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Used to spawn in enemies into the scene**/
public class SpawnerBehavior : MonoBehaviour
{
    /**
     * Sets the object that the spawner spawns, the target and the time it takes to spawn Gameobjects.**/
    public GameObject objectToSpawn;
    public GameObject behaviorTarget;
    public float spawnInterval = 5;

    public float timeRemaining = 5;

    // Update is called once per frame
    void Update()
    {
        /**
         * Updates the time remaining to spawn a GameObject**/
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timeRemaining = spawnInterval;

            spawnObject();
        }
    }

    /**
     * Spawns a GameObject.**/
    public void spawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
        PursueBehavior seekBehavior = spawnedObject.GetComponent<PursueBehavior>();
        seekBehavior.target = behaviorTarget;
    }
}
