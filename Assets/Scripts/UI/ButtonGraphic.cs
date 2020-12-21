using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ButtonGraphic : MonoBehaviour
{
    public Sprite normalBtn;
    public Sprite pressBtn;

    private SpriteRenderer sprRend;

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
        }
        else if (!redBtn)
        {
            if (Input.GetKey(GameStarter.Instance.currentSettings.BlueKey))
                sprRend.sprite = pressBtn;
            else
                sprRend.sprite = normalBtn;
        }
    }
}
