using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using NaughtyAttributes;


public class ReturnToStartOption : Option
{
    [Scene]
    public string targetScene;
    public override void OnActive()
    {
        SceneManager.LoadScene("StartScene");
        
    }
}
