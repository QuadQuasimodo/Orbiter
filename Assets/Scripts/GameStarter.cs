using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GameSettingsHolder defaultSettings;
    public GameSettingsHolder currentSettings;

    private static bool firstStart = true;

    public static GameStarter Instance;


    void Start()
    {
        if (firstStart)
        {
            currentSettings.MatchSettings(defaultSettings);
            firstStart = false;
        }
        
        this.InstantiateController();
    }
    

    private void InstantiateController()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Destroy(this.gameObject);
        }
    }
}
