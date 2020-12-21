using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlipOption : Option
{
    public override void HandleBlue()
    {
        currentSettings.FlipControls = true;
    }

    public override void HandleRed()
    {
        currentSettings.FlipControls = false;
    }

}
