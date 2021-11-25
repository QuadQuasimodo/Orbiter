using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockwiseOPtion : Option
{
    /*public override void HandleBlue()
    {
        
    }*/

    /*public override void HandleRed()
    {
        currentSettings.clockWise = false;
    }*/

    public override void OnActive()
    {
        currentSettings.clockWise = !currentSettings.clockWise;
        this.active = false;
    }
}
