using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekBehavior : MonoBehaviour
{
    public Transform target;

    public float movementSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = target.position - transform.position;

        movementDirection.Normalize();

        movementDirection *= movementSpeed;

        transform.Translate(movementDirection * Time.deltaTime);
    }
}
