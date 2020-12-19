using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Settings")]
public class GameSettingsHolder : ScriptableObject
{
    [SerializeField]
    [Range(0, 400)]
    private float playerSpeed;

    public float PlayerSpeed {get => clockWise ? -playerSpeed : playerSpeed;}

    public bool clockWise = true;

    [Range(-2.00f, 2.00f)]
    public float orbiterSpeedModifier;
    private KeyCode flipKey = KeyCode.Z;
    private KeyCode orbitKey = KeyCode.X;

    public KeyCode DirectionKey {get => FlipControls ? orbitKey : flipKey;}
    public KeyCode OrbitKey {get => FlipControls ? flipKey : orbitKey;}

    public KeyCode RedKey {get => FlipControls ? OrbitKey : DirectionKey;}
    public KeyCode BlueKey {get => FlipControls ? OrbitKey : DirectionKey;}

    public bool FlipControls = false;

    /// <summary>
    /// Blue is X
    /// Red is Z
    /// </summary>
    


}
