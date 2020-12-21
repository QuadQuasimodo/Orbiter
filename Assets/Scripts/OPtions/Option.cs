using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public bool active = false;
    public GameSettingsHolder currentSettings;
    public Text displaytext;

    private void Update()
    {
        if (!active)
        {
            if (displaytext)
                displaytext.color = Color.white;
            return;
        }
           

            if (Input.GetKeyUp(currentSettings.BlueKey))
                HandleBlue();
            if (Input.GetKeyUp(currentSettings.RedKey))
                HandleRed();

            if (Input.GetKey(currentSettings.RedKey) && Input.GetKey(currentSettings.BlueKey))
                active = false;

        if(displaytext)
            displaytext.color = Color.yellow;

    }

    public virtual void OnActive() { }
    public virtual void HandleBlue() { }
    public virtual void HandleRed() { }
}
