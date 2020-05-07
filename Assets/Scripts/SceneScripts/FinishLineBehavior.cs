using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Moves the player from one scene to another.**/
public class FinishLineBehavior : MonoBehaviour
{
    /**
     * Sets the game over ui, shootbehavior, movementbehavior and the spawners.**/
    public ShootBehavior shootBehavior;
    public MovementBehavior movementBehavior;
    public Canvas gameOverUI;
    public GameObject spawners;

    /**
     * Activates Game over screen.**/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            shootBehavior.enabled = false;
            movementBehavior.enabled = false;
            spawners.SetActive(false);
            gameOverUI.gameObject.SetActive(true);
        }
    }
}
