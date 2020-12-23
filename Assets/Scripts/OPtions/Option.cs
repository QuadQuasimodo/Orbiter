﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public bool active = false;
    public GameSettingsHolder currentSettings;
    public Text displaytext;

    protected float inputDamp = 0.2f;
    private float dampCount = 0;

    private void Update()
    {
        if (!active)
        {
            dampCount = 0;
            if (displaytext)
                displaytext.color = Color.white;
            return;
        }
        dampCount += Time.deltaTime;

        if (Input.GetKeyUp(currentSettings.BlueKey) && dampCount > inputDamp)
        {
            HandleBlue();
            
        }

        if (Input.GetKeyUp(currentSettings.RedKey) && dampCount > inputDamp)
        {
            
            HandleRed();

        }


        if (Input.GetKey(currentSettings.RedKey) && Input.GetKey(currentSettings.BlueKey) && dampCount > inputDamp)
        {
            dampCount = 0;
            active = false;
        }
                

        if(displaytext)
            displaytext.color = Color.yellow;

    }

    public virtual void OnActive() { }
    public virtual void HandleBlue() { }
    public virtual void HandleRed() { }
}
