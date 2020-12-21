using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockwiseDisplay : MonoBehaviour
{
    public Toggle toggle;


    // Update is called once per frame
    void Update()
    {
        if (toggle)
            toggle.isOn = GameStarter.Instance.currentSettings.clockWise;
    }
}
