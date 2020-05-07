using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Handles player collisions.**/
public class PlayerCollisionBehavior : MonoBehaviour
{
    /**
     * Sets the health of the player.**/
    private float health;
    public float maxHealth = 100;
    
    /**
     * Gives the player invincibility after being hit.**/
    private bool damaged = false;
    /**
     * Timer that keeps track of how long the player is invincible.**/
    private float timeToRecover = 1;
    /**
      * How long the player is invincible after being hit.**/
    private float recovery;

    /**
     * GameObject that is used as the health bar**/
    public GameObject healthBar;

    /**
     * Takes in the GameObjects that need to be disabled after the player loses all their health.**/
    public ShootBehavior shootBehavior;
    public MovementBehavior movementBehavior;
    public Canvas gameOverUI;
    public GameObject spawners;

    private void Start()
    {
        /**
         * Sets the starting health and recovery.**/
        health = maxHealth;
        recovery = timeToRecover;
    }

    private void Update()
    {
        IsInvincible();
        /**
         * Sets the health bars size depending on health remaining**/
        float healthBarScale = health / maxHealth;

        healthBar.transform.localScale = new Vector3(healthBarScale, 1, .25f);

        CheckHealth();
    }

    /**
     * Decreases health on collision with an enemy.**/
    private void OnCollisionEnter(Collision collision)
    {
        if(!damaged && collision.gameObject.tag == "Enemy")
        {
            health -= 20;
            damaged = true;
        }
    }

    /**
     * Disables the GameObjects taken if player's health hits 0.**/
    public void CheckHealth()
    {
        if (health <= 0)
        {
            shootBehavior.enabled = false;
            movementBehavior.enabled = false;
            gameOverUI.gameObject.SetActive(true);
            spawners.SetActive(false);
            enabled = false;
        }
    }

    /**
         * Handles dealing with recovery.**/
    public void IsInvincible()
    {
        if (damaged)
        {
            timeToRecover -= Time.deltaTime;
            if (timeToRecover <= 0)
            {
                damaged = false;
                timeToRecover = recovery;
            }
        }
    }
}
