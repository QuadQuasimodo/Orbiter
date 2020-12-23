using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StageCounter : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = LevelScript.levelInstance.currentStangeNumber.ToString();        
    }
}
