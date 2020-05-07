using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Handles enemy collisions.**/
public class EnemyCollisionBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
