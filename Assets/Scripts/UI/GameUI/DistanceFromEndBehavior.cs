using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Used to display how far the player is from the end.**/
public class DistanceFromEndBehavior : MonoBehaviour
{
    /**
     * Sets the text and the transform of the player and the endpoint.**/
    public Text endDistanceText;

    public Transform player;

    public Transform endPoint;

    // Update is called once per frame
    void Update()
    {
        /**
         * Updates the distance text.**/
        if (player == null)
            return;

        float distance = endPoint.position.z - player.position.z;

        endDistanceText.text = ((int)distance).ToString();
    }
}
