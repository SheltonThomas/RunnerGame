using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Controls the ammo counter**/
public class AmmoBehavior : MonoBehaviour
{
    /**
     * Sets the shoot behavior.**/
    public ShootBehavior shootBehavior;

    /**
     * Sets the text that will be modified.**/
    public Text ammoCounterText;

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    /**
     * Updates the ammo counter.**/
    public void UpdateText()
    {
        string ammoCounter = shootBehavior.GetAmmoCount().ToString() + "/" + shootBehavior.maxAmmo.ToString();
        ammoCounterText.text = ammoCounter;
    }
}
