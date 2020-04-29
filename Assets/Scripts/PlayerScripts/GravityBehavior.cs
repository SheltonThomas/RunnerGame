using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBehavior : MonoBehaviour
{
    public float gravity = 50;

    private bool canSwapGravity;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -gravity);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempGravity = Physics.gravity;
        if(Input.GetButtonDown("Jump") && canSwapGravity)
        {
            Physics.gravity = -tempGravity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Wall")
        {
            canSwapGravity = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            canSwapGravity = false;
        }
    }
}
