using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public bool active = false;
    public GameSettingsHolder currentSettings;
    public Text displaytext;

    protected float inputDamp = 0.4f;
    private float dampCount = 0;

    private void Update()
    {
        if (!active)
        {
            dampCount = 0;
            if (displaytext)
                displaytext.color = Color.white;
            return;
        }
        dampCount += Time.deltaTime;
        print(dampCount);
        if ((Input.GetKeyUp(currentSettings.BlueKey) || Input.GetKeyUp(KeyCode.RightArrow)) && dampCount > inputDamp)
        {
            HandleBlue();
            
        }

        /*if ((Input.GetKeyUp(currentSettings.RedKey) || Input.GetKeyUp(KeyCode.LeftArrow)) && dampCount > inputDamp)
        {
            
            HandleRed();

        }*/


        //if (((Input.GetKey(currentSettings.RedKey) && Input.GetKey(currentSettings.BlueKey)) || (Input.GetKeyDown(KeyCode.Return))) && dampCount > inputDamp)
        if(Input.GetKeyUp(currentSettings.RedKey) && dampCount > inputDamp ) //Red leaves option
        {
            
            active = false;
        }
                

        if(displaytext)
            displaytext.color = Color.yellow;

    }

    public virtual void OnActive() { }
    public virtual void HandleBlue() { }

    // This is never called now with the if above commented out
    public virtual void HandleRed() { }
}
