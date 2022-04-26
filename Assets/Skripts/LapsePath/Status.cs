using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    Sprites Chek;
    public int Score_Icon;

    [Header("Image")]
    [SerializeField] private Image Spiritu;
    [SerializeField] private Image Social;
    [SerializeField] private Image Economy;
    [SerializeField] private Image Politics;

    [Header("Sprites")]
    [SerializeField] private Sprite[] Spiritu1;
    [SerializeField] private Sprite[] Social1;
    [SerializeField] private Sprite[] Economy1;
    [SerializeField] private Sprite[] Politics1;


    public void Switch_Status()
    {
        if (Score_Icon > 0)
        {
            if (Chek.TagAcite == "Spirituality") Spiritu.sprite = Spiritu1[Score_Icon];
            if (Chek.TagAcite == "Sociality") Social.sprite = Social1[Score_Icon];
            if (Chek.TagAcite == "Economy") Economy.sprite = Economy1[Score_Icon];
            if (Chek.TagAcite == "Politics") Politics.sprite = Politics1[Score_Icon];
        }
       
    }
}
