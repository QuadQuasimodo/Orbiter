using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyOrbiter : MonoBehaviour
{
    public Transform center;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position, Vector3.forward, GameStarter.Instance.currentSettings.PlayerSpeed * Time.deltaTime);
    }
}
