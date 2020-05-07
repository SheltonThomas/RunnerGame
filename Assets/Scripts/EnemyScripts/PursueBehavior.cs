using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Used to make an agent pursue the something.**/
public class PursueBehavior : MonoBehaviour
{
    /**
     * The target for the enemy to follow.**/
    public GameObject target;
    /**
     * The targets last location.**/
    private Vector3 targetsLastLocation;

    /**
     * Enemies movement speed.**/
    public float movementSpeed = 10;

    private void Start()
    {
        /**
         * Sets targets last location to its current position.**/
        targetsLastLocation = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /**
         * Sets target position for the agent.**/
        Vector3 targetPosition = target.transform.position + ((target.transform.position - targetsLastLocation) / Time.deltaTime);

        /**
         * Sets agents movement direction.**/
        Vector3 movementDirection = targetPosition - transform.position;

        movementDirection.Normalize();

        movementDirection *= movementSpeed;

        /**
         * Moves the agent towards the target location.**/
        transform.Translate(movementDirection * Time.deltaTime);

        /**
         * Sets targets last location to its current position.**/
        targetsLastLocation = target.transform.position;
    }
}
