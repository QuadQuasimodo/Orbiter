using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuScript : MonoBehaviour
{
    private float inputDamp = 40f;
    private float dampCount = 0;

    // Update is called once per frame
    void Update()
    {
        dampCount++;

        if (Input.GetKeyUp(GameStarter.Instance.currentSettings.BlueKey) )
        {
            print("BLUE");
           SceneManager.LoadScene("MainGame");
         
        }
       /* if (Input.GetKeyUp(GameStarter.Instance.currentSettings.RedKey) && dampCount > inputDamp)
        {
            //SceneManager.LoadScene("MainGame");
            print("Red");
        }*/

        if (Input.GetKey(GameStarter.Instance.currentSettings.BlueKey) &&
            Input.GetKey(GameStarter.Instance.currentSettings.RedKey) && dampCount > inputDamp)
        {
            print("RED and BLUE");
            SceneManager.LoadScene("OptionsScene");
            
            dampCount = 0;
        }


    }
}
