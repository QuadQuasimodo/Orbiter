using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceControls : MonoBehaviour
{
    private float inputDamp = 0.4f;
    private float dampCount = 0;

    public GameSettingsHolder defaultSettings;
    public GameSettingsHolder currentSettings;

    public List<Option> options;

    private Option _selectedOpt;

    private int index = 0;

    private void Start()
    {
        _selectedOpt = options[0];
    }
    private void Update()
    {
        
        _selectedOpt = options[index];
        

        if (_selectedOpt.active)
        {
            dampCount = 0;
            return;
        }
            
        dampCount += Time.deltaTime;
        //print(_selectedOpt);
        // Blue Down the Menu
        if ((Input.GetKeyUp(currentSettings.BlueKey) || Input.GetKeyDown(KeyCode.DownArrow)) && dampCount > inputDamp)
        {
            print("ble");
            index++;
      

        }

        // Red goes up the Menu
        if ((Input.GetKeyUp(currentSettings.RedKey) || Input.GetKeyDown(KeyCode.UpArrow)) && dampCount > inputDamp)
        {
            print("red");
            index--;
           

        }


        index = Mathf.Clamp(index, 0, options.Count - 1);



        if (((Input.GetKey(currentSettings.RedKey) && Input.GetKey(currentSettings.BlueKey)) || Input.GetKeyDown(KeyCode.Return)) && dampCount > inputDamp)
        {
            print("Enter Option");
            
            _selectedOpt.active = true;
            _selectedOpt.OnActive();
            dampCount = 0;
           

        }

        if (_selectedOpt.displaytext)
            _selectedOpt.displaytext.fontStyle = FontStyle.Bold;

        for (int i = 0; i < options.Count; i++)
        {
            if (i == index)
                continue;

            if (options[i].displaytext)
                options[i].displaytext.fontStyle = FontStyle.Normal;
        }




    }


}
