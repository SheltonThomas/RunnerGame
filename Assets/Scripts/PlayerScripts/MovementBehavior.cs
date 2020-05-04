using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementBehavior : MonoBehaviour
{
    public float levelOneMovementSpeed = 10;
    public float levelTwoMovementSpeed = 5;
    public Transform target;

    [SerializeField]
    private GravityBehavior gravityBehavior;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target == null)
        {
            Vector3 movement = new Vector3(levelOneMovementSpeed, 0, 0);

            transform.Translate(movement * Time.deltaTime);
        }
        else
        {
            Vector3 movementDirection = (target.position - transform.position);
            movementDirection.Normalize();

            transform.Translate(movementDirection * Time.deltaTime * levelTwoMovementSpeed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Obstacle")
        {
            enabled = false;
            gravityBehavior.enabled = false;
        }
    }
}
