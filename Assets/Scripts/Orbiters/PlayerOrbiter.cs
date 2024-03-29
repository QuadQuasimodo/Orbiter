﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrbiter : OrbiterBase
{
    [Header("Player Specific Variables")]
    public int maxLife = 3;
    public int life;


    public float orbitCooldownCounter;
    public float flipCooldownCounter;

    public GameObject forwardChecker;

    [HideInInspector]
    public OrbitCheckerScript forwardOrbiter;

    private KeyCode orbitJumpKey => settings.OrbitKey;
    private KeyCode changeDirectionKey => settings.DirectionKey;

    public float currSpeed;
    new float orbitSpeed;

    [SerializeField] private bool isImmortal = true;

    [SerializeField]
        private BumperScript leftBumper;
    [SerializeField]
        private BumperScript rightBumper;

    [SerializeField]
    private GameSettingsHolder settings;
    private LivesManager livesManager;

    // Start is called before the first frame update
    
    void Awake()
    {
        Setup();

        livesManager = FindObjectOfType<LivesManager>();

        leftBumper.myOrbiter = this;
        rightBumper.myOrbiter = this;
        orbitSpeed = settings.PlayerSpeed;
        currSpeed = orbitSpeed;
        life = maxLife;
        orbitCooldownCounter = 0;
        GameObject instantiated = Instantiate(forwardChecker, transform.position + transform.up * LevelScript.levelInstance.orbitDistance, transform.rotation,this.transform);
        forwardOrbiter = instantiated.GetComponent<OrbitCheckerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        orbitCooldownCounter += Time.deltaTime;
        flipCooldownCounter += Time.deltaTime;

        if (!blockMovement)
            transform.RotateAround(Vector3.zero, Vector3.forward, currSpeed * Time.deltaTime);

        if (Input.GetKeyDown(changeDirectionKey) )
        {
            print($"START Current speed: {currSpeed} -- Orbit Speed: {orbitSpeed}");

            if (currSpeed != 0)
            {
                currSpeed *= -1;
                orbitSpeed *= -1;
            }
            else if (currSpeed == 0)
            {
                print("flip");
                currSpeed = orbitSpeed;
                currSpeed *= -1;
                orbitSpeed *= -1;
            }
            flipCooldownCounter = 0;


            print($"END Current speed: {currSpeed} -- Orbit Speed: {orbitSpeed}");
        }
        
        if (Input.GetKeyDown(orbitJumpKey) )
        {
            // allow jump if on last orbit no matter what since everything is so tight together there.
            if (!(forwardOrbiter.isObstructed && currentOrbit != 1))
            {
                transform.position += transform.up * LevelScript.levelInstance.orbitDistance;
                orbitCooldownCounter = 0;
                currentOrbit--;
                currSpeed = orbitSpeed;
            }
        }

        if (currentOrbit == 0)
            LevelScript.levelInstance.WinStage();

        if (life <= 0 && !isImmortal)
        {
            LevelScript.levelInstance.LoseStage();
        }

    }

    public override void BumperHit(OrbiterBase other, bool rightSide)
    {
        Debug.Log("bonk");
        if (other.GetType() == typeof(PlanetoidOrbiter) ||
            other.GetType() == typeof(EnemyOrbitrer))
        {
            if (!isImmortal)
            {
                life--;
                livesManager.DisableLife(maxLife - life - 1);
            }
                
            

            Setup();
        }
        else if (other.GetType() == typeof(OrbiterBase))
        {
            currSpeed = 0;
        }
    }
}
