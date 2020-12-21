using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class ButtonGraphic : MonoBehaviour
{
    public Sprite normalBtn;
    public Sprite pressBtn;

    private SpriteRenderer sprRend;
    public Text functionText;

    public bool redBtn;

    private void Awake()
    {
        sprRend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (redBtn)
        {
            if (Input.GetKey(GameStarter.Instance.currentSettings.RedKey))
                sprRend.sprite = pressBtn;
            else
                sprRend.sprite = normalBtn;

            if (GameStarter.Instance.currentSettings.RedKey == GameStarter.Instance.currentSettings.DirectionKey)
                functionText.text = $"[{GameStarter.Instance.currentSettings.DirectionKey}] Switch Directions";
            else
                functionText.text = $"[{GameStarter.Instance.currentSettings.OrbitKey}] Jump Orbits";

        }
        else if (!redBtn)
        {
            if (Input.GetKey(GameStarter.Instance.currentSettings.BlueKey))
                sprRend.sprite = pressBtn;
            else
                sprRend.sprite = normalBtn;

            if (GameStarter.Instance.currentSettings.BlueKey == GameStarter.Instance.currentSettings.DirectionKey)
                functionText.text = $"[{GameStarter.Instance.currentSettings.DirectionKey}] Switch Directions";
            else
                functionText.text = $"[{GameStarter.Instance.currentSettings.OrbitKey}] Jump Orbits";
        }
    }
}
