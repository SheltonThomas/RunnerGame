using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionBehavior : MonoBehaviour
{
    public float health = 10;
    private bool damaged = false;

    private float timeToRecover = 1;
    public float recovery = 1;

    public GameObject healthBar;

    private void Update()
    {
        if(damaged)
        {
            timeToRecover -= Time.deltaTime;
            if (recovery <= 0)
            {
                damaged = false;
                timeToRecover = recovery;
            }
        }

        float healtBarScale = health * .1f;
        healthBar.transform.localScale = new Vector3(healtBarScale, 1, .25f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!damaged && collision.gameObject.tag == "Enemy")
        {
            health--;
            damaged = true;
        }
    }
}
