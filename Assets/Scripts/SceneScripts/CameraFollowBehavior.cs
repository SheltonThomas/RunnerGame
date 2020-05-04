using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollowBehavior : MonoBehaviour
{
    public Transform target;

    private Vector3 distanceFromTarget;
    public Vector3 offset = new Vector3(0, 0, 0);
    private float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        distanceFromTarget = transform.position - target.position + offset;
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = distanceFromTarget + target.position + offset;
        if (SceneManager.GetActiveScene().name == "GravitySwitch")
        {
            cameraPosition.y = yPosition;
        }
        transform.position = cameraPosition;
    }
}
