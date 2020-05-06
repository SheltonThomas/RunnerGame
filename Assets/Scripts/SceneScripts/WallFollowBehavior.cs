using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFollowBehavior : MonoBehaviour
{
    private Vector3 distanceFromTarget;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        distanceFromTarget = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wallPostion = distanceFromTarget + target.position;
        transform.position = wallPostion;
    }
}
