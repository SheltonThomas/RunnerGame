using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceFromEndBehavior : MonoBehaviour
{
    public Text endDistanceText;

    public Transform player;

    public Transform endPoint;

    // Update is called once per frame
    void Update()
    {
        float distance = endPoint.position.z - player.position.z;

        endDistanceText.text = ((int)distance).ToString();
    }
}
