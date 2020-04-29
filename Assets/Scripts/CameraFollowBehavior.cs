using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehavior : MonoBehaviour
{
    public Transform target;

    private Vector3 distanceFromTarget;

    private float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        distanceFromTarget = transform.position - target.position;
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = distanceFromTarget + target.position;
        cameraPosition.y = yPosition;
        transform.position = cameraPosition;
    }
}
