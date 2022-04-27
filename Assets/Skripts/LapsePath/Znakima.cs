using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Znakima : MonoBehaviour
{
    [Header("Image")]
    [SerializeField] private Image Znak;

    [Header("Sprites")]
    [SerializeField] private Sprite[] Znaki;


    public void ChangeImage()
    {
        if (Sprites.TagAcite == "Spirituality")
        {
            Znak.sprite = Znaki[0];
        }
        if (Sprites.TagAcite == "Sociality")
        {
            Znak.sprite = Znaki[1];
        }
        if (Sprites.TagAcite == "Economy")
        {
            Znak.sprite = Znaki[2];
        }
        if (Sprites.TagAcite == "Politics")
        {
            Znak.sprite = Znaki[3];
        }
    }

    private void FixedUpdate()
    {
        ChangeImage();
    }
}
