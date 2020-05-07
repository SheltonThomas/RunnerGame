using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Controls the timer for regenerating ammo.**/
public class TimerBehavior : MonoBehaviour
{
    /**
     * Sets the shoot behavior.**/
    public ShootBehavior shootBehavior;

    // Update is called once per frame
    void Update()
    {
        ScaleBar();
        
    }

    /**
     * Scales the ammo bar.**/
    public void ScaleBar()
    {
        Vector3 cubeScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(cubeScale.x, (shootBehavior.GetAmmoTimer() / shootBehavior.ammoRegenRate), cubeScale.z);
    }
}
