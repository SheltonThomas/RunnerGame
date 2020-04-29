using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementBehavior : MonoBehaviour
{
    public float levelTowMovementSpeed = 5;
    public float levelOneMovementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Running")
        {
            Vector3 movementDirection = new Vector3(0, 0, 0);

            movementDirection += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movementDirection.Normalize();

            movementDirection *= levelTowMovementSpeed;

            transform.Translate(movementDirection * Time.deltaTime);
        }
        else
        {
            Vector3 movement = new Vector3(levelOneMovementSpeed, 0, 0);

            transform.Translate(movement * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Obstacle")
        {
            enabled = false;
        }
    }
}
