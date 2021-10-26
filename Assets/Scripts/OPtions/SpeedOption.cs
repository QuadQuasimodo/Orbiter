using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedOption : Option
{
    public override void HandleBlue()
    {
        print("Increase Speed");
        if(currentSettings.PlayerSpeed >= 100)
        {
            currentSettings.ChangePlayerSpeed(-100);
            return;
        }
        currentSettings.ChangePlayerSpeed(25);

    }

    public override void HandleRed()
    {
        print("Decrease Speed");
        currentSettings.ChangePlayerSpeed(-1);
    }
}
