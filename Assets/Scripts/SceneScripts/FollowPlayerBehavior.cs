using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Follow behavior for walls, spawners, and camera.**/
public class FollowPlayerBehavior : MonoBehaviour
{
    /**
     * Keeps the GameObjects the same distance from the target.**/
    private Vector3 distanceFromTarget;

    /**
     * Sets the target to a GameObject.**/
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        /**
         * Sets the distance from the target.**/
        distanceFromTarget = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        /**
         * Updates the position of the GameObject.**/
        Vector3 wallPostion = distanceFromTarget + target.position;
        transform.position = wallPostion;
    }
}
