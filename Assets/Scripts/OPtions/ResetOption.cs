using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOption : Option
{
    public GameSettingsHolder defaultSettings;

    public override void OnActive()
    {
        currentSettings.MatchSettings(defaultSettings);
        active = false;
    }
}
