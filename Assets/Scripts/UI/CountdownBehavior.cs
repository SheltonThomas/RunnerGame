using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownBehavior : MonoBehaviour
{
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
