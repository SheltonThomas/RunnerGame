using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionBehavior : MonoBehaviour
{
    public float health = 100;
    private bool damaged = false;

    private float timeToRecover = 1;
    public float recovery = 1;

    public GameObject healthBar;

    private void Update()
    {
        if(damaged)
        {
            timeToRecover -= Time.deltaTime;
            if (timeToRecover <= 0)
            {
                damaged = false;
                timeToRecover = recovery;
            }
        }

        float healthBarScale = health / 100;
        healthBar.transform.localScale = new Vector3(healthBarScale, 1, .25f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!damaged && collision.gameObject.tag == "Enemy")
        {
            health -= 20;
            damaged = true;
        }
    }
}
