using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockwiseOPtion : Option
{
    public override void HandleBlue()
    {
        currentSettings.clockWise = true;
    }

    public override void HandleRed()
    {
        currentSettings.clockWise = false;
    }
}
