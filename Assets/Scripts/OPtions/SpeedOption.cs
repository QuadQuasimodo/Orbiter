using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedOption : Option
{
    public override void HandleBlue()
    {
        print("Increase Speed");
        currentSettings.ChangePlayerSpeed(1);        
    }

    public override void HandleRed()
    {
        print("Decrease Speed");
        currentSettings.ChangePlayerSpeed(-1);
    }
}
