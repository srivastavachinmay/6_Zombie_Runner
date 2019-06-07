﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: responsible for increasing and decreasing flashlight's effectiveness

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void AddLightIntensity(float batteryAmount)
    {
        myLight.intensity += batteryAmount;
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }

    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle) 
        { 
            return; 
        }
        else 
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }


}