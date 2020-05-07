using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Handles shooting for the player.**/
public class ShootBehavior : MonoBehaviour
{
    /**
     * GameObject that will be used as a bullet.**/
    public GameObject bullet;

    /**
     * Keeps track of everything that has to do with ammo.**/
    public int maxAmmo;
    private int ammoCount;
    public float ammoRegenRate;
    private float ammoTimer;

    // Start is called before the first frame update
    void Start()
    {
        /**
         * Sets the ammo to max ammo and sets ammo timer to ammo regen rate.**/
        ammoCount = maxAmmo;
        ammoTimer = ammoRegenRate;
    }

    // Update is called once per frame
    void Update()
    {
        SetFacing();
        /**
         * Shoots a bullet if the player has ammo.**/
        if (Input.GetMouseButtonDown(0) && ammoCount != 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            ammoCount--;
        }
        /**
         * Regens ammo.**/
        AmmoRegen();
    }

    /**
     * Regenerates bullets as time passes**/
    public void AmmoRegen()
    {
        /**
         * If the player has ammo then return out of function.**/
        if (ammoCount == maxAmmo)
            return;

        /**
         * Reduces the ammo timer.**/
        ammoTimer -= Time.deltaTime;

        /**
         * If the ammo timer is less than or equal to 0, then increase ammo count and reset the timer.**/
        if(ammoTimer <= 0)
        {
            ammoCount++;
            ammoTimer = ammoRegenRate;
        }
    }

    /**
     * Faces the player in the direction that the mouse is pointing.**/
    public void SetFacing()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        float rayDistance = 0;

        playerPlane.Raycast(mouseRay, out rayDistance);

        Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

        Vector3 fireDirection = targetPoint - transform.position;

        transform.forward = fireDirection;
    }

    /**
     * Returns ammo count.**/
    public int GetAmmoCount()
    {
        return ammoCount;
    }

    /**
     * Returns ammo timer.**/
    public float GetAmmoTimer()
    {
        return ammoTimer;
    }
}
