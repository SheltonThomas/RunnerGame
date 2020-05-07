using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Used for the countdown before the game starts.**/
public class CountdownBehavior : MonoBehaviour
{
    /**
     * Sets time to start and takes in all the GameObjects that it needs to enable**/
    public float timeToStart = 5;
    public Text countdown;
    public MovementBehavior playerMovement;
    public ShootBehavior playerShooting;
    public CountdownBehavior countdownBehavior;
    public Text startingWords;

    void Start()
    {
        timeToStart++;
    }

    // Update is called once per frame
    void Update()
    {
        /**
         * Updates the time text.**/
        timeToStart -= Time.deltaTime;
        countdown.text = ((int)timeToStart).ToString();
        if(timeToStart < 1f)
        {
            playerMovement.enabled = true;
            playerShooting.enabled = true;

            countdown.enabled = false;
            startingWords.enabled = false;
            countdownBehavior.enabled = false;
        }
    }
}
