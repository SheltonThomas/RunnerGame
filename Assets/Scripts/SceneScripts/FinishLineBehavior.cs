using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Moves the player from one scene to another.**/
public class FinishLineBehavior : MonoBehaviour
{
    /**
     * Sets the game over ui.**/
    public Canvas gameOverUI;

    /**
     * Activates Game over screen.**/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameOverUI.gameObject.SetActive(true);
        }
    }
}
