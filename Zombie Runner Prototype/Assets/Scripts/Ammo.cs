﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: ammo is current on the individuals weapons. May be better stored in weapon system.
// rename to weapon

public enum AmmoType{Bullets, Shells, Rockets};


public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoType ammoType;
    [SerializeField] int currentAmmo = 10;
    
    public int GetCurrentAmmo()
    {
        return currentAmmo;
    }

    public void ReduceAmmo()
    {
        if (currentAmmo <= 0)
        {
            Debug.Log("Out of Ammo");
            // Play the 'no ammo' sound
            return;
            
        }
        else
        {
            currentAmmo --;
        }
    }

    public void IncreaseAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;        
    }
}