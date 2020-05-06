﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollowBehavior : MonoBehaviour
{
    public Transform target;

    private Vector3 distanceFromTarget;

    // Start is called before the first frame update
    void Start()
    {
        distanceFromTarget = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 cameraPosition = distanceFromTarget + target.position;
        transform.position = cameraPosition;
    }
}
