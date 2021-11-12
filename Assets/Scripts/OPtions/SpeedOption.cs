using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedOption : Option
{
    public override void HandleBlue()
    {
        
        if(Mathf.Abs(currentSettings.PlayerSpeed) >= 100)
        {
            currentSettings.ChangePlayerSpeed(-Mathf.Abs(currentSettings.PlayerSpeed));
            return;
        }
        currentSettings.ChangePlayerSpeed(25);
        print(currentSettings.PlayerSpeed);

    }

    /*public override void HandleRed()
    {
        print("Decrease Speed");
        currentSettings.ChangePlayerSpeed(-1);
    }*/
}
