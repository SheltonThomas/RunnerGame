using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Moves the player from one scene to another.**/
public class FinishLineBehavior : MonoBehaviour
{
    /**
     * Sets the next scene's id.**/
    public int nextSceneId;

    /**
     * Moves player to next scene.**/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextSceneId);
        }
    }
}
