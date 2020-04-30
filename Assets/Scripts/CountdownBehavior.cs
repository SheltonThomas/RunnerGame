using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownBehavior : MonoBehaviour
{
    public float timeToStart = 5;
    public TextMesh countdown;
    public MovementBehavior playerMovement;
    public GravityBehavior gravity;

    void Start()
    {
        countdown.alignment = TextAlignment.Center;
        timeToStart++;
    }

    // Update is called once per frame
    void Update()
    {
        timeToStart -= Time.deltaTime;
        countdown.text = ((int)timeToStart).ToString();
        if(timeToStart < 1f)
        {
            gameObject.SetActive(false);
            playerMovement.enabled = true;
            gravity.enabled = true;
        }
    }
}
