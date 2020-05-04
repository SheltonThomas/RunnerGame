using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A MonoBehavior for adding score on the first level of the game.
 * **/
public class CoinBehavior : MonoBehaviour
{
    /**
     * Gets the ScoreBehavior for adding score.
     * **/
    public ScoreBehavior score;


    private void Update()
    {
        /** 
         * Constantly rotates the coins.
         * **/
        transform.Rotate(0, 0, 100 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        /** 
         * On collision, add to the score and destroy the coin.
         * **/
        score.score += 10;
        Destroy(gameObject);
    }
}
