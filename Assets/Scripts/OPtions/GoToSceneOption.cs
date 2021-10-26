using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using NaughtyAttributes;


public class GoToSceneOption : Option
{
    [Scene]
    public string targetScene;
    public override void OnActive()
    {
        SceneManager.LoadScene(targetScene);
        
    }
}