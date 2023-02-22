using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpriteEvent : MonoBehaviour
{
    public GeneratedSpritesEnum enumval;

    void Start()
    {
        UpdateSprite();
    }

    public void UpdateSprite()//SpriteManager.spriteListEnum enumVal)
    {
        Image image = GetComponent<Image>();
        image.sprite = SpriteManager.instance.spritesDic[enumval.ToString()].sprite;
    }
}
