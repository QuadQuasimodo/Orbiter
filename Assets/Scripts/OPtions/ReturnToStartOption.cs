using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStartOption : Option
{
    public override void OnActive()
    {
        SceneManager.LoadScene("StartScene");
        
    }
}
