using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Moves the player forward.**/
public class MovementBehavior : MonoBehaviour
{
    /**
     * Movement speed of the player.**/
    public float movementSpeed = 10;
    /**
     * Sets the target that the player moves towards.**/
    public Transform target;

    // Update is called once per frame
    void FixedUpdate()
    {
        /**
         * Moves the player forward.**/
        Vector3 movementDirection = (target.position - transform.position);
        movementDirection.Normalize();

        transform.Translate(movementDirection * Time.deltaTime * movementSpeed);
    }
}
