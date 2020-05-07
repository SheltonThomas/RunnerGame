using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Used to move bullets on the scene.**/
public class BulletBehavior : MonoBehaviour
{
    /**
     * Sets the bullets speed.**/
    public float bulletSpeed = 2;

    /**
     * Used to update the score.**/
    public ScoreBehavior score;

    /**
    * Gets the position of the mouse and sets the transform forward of the bullet to face the mouse.**/
    public void SetForward()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        float rayDistance = 0;

        playerPlane.Raycast(mouseRay, out rayDistance);

        Vector3 target = mouseRay.GetPoint(rayDistance);

        Vector3 fireDirection = target - transform.position;

        transform.forward = fireDirection;

        score = GameObject.Find("Score").GetComponent<ScoreBehavior>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SetForward();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /**
         * Moves the bullet forward.**/
        transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        /**
         * Makes it so bullets can't collide with the player and can't collide with other bullets.**/
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
            return;

        /**
         * Destroys the bullet if it hits a wall.**/
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            return;
        }

        /**
         * If the bullet collides with anything else it will destroy the object and the bullet and 
         * update the score.**/
        Destroy(collision.gameObject);
        Destroy(gameObject);
        score.score += 5;
    }
}
