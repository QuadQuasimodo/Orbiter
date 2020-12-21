using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeedSlider : MonoBehaviour
{
    public Slider slider;
    public Text valueText;

    // Update is called once per frame
    void Update()
    {
        if(slider)
            slider.value = Mathf.Abs(GameStarter.Instance.currentSettings.PlayerSpeed);

        if(valueText)
            valueText.text = slider.value.ToString();
    }
}
