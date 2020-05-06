using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementBehavior : MonoBehaviour
{
    public float movementSpeed = 10;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Vector3 movementDirection = (target.position - transform.position);
            movementDirection.Normalize();

            transform.Translate(movementDirection * Time.deltaTime * movementSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Obstacle")
        {
            enabled = false;
        }
    }
}
