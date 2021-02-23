using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ButtonGraphic : MonoBehaviour
{
    public Sprite normalBtn;
    public Sprite pressBtn;

    private SpriteRenderer sprRend;
    public Image image;
    public Text functionText;

    public bool redBtn;

    private void Awake()
    {
        sprRend = GetComponent<SpriteRenderer>();
        //image = GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        if (redBtn)
        {
            if (Input.GetKey(GameStarter.Instance.currentSettings.RedKey))
                image.sprite = pressBtn;
            else
                image.sprite = normalBtn;

            if (GameStarter.Instance.currentSettings.RedKey == GameStarter.Instance.currentSettings.DirectionKey)
                functionText.text = $"trocar direcção";
            else
                functionText.text = $"avançar orbita";

        }
        else if (!redBtn)
        {
            if (Input.GetKey(GameStarter.Instance.currentSettings.BlueKey))
                image.sprite = pressBtn;
            else
                image.sprite = normalBtn;

            if (GameStarter.Instance.currentSettings.BlueKey == GameStarter.Instance.currentSettings.DirectionKey)
                functionText.text = $"trocar direcção";
            else
                functionText.text = $"avançar orbita";
        }
    }
}
