using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    private static int Score_Icon_Economy = 2;
    private static int Score_Icon_Social = 2;
    private static int Score_Icon_Spiritu = 2;
    private static int Score_Icon_Politics = 2;

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
        if (RandomLaw.ChekChislo == 1 & Score_Icon_Spiritu <= 4)
        {
            Score_Icon_Spiritu += 1;
            Spiritu.sprite = Spiritu1[Score_Icon_Spiritu];
        }
        if (RandomLaw.ChekChislo == 4 & Score_Icon_Social <= 4)
        {
            Score_Icon_Social += 1;
            Social.sprite = Social1[Score_Icon_Social];
        }
        if (RandomLaw.ChekChislo == 3 & Score_Icon_Economy <= 4)
        {
            Score_Icon_Economy += 1;
            Economy.sprite = Economy1[Score_Icon_Economy];
        }
        if (RandomLaw.ChekChislo == 2 & Score_Icon_Politics <= 4)
        {
            Score_Icon_Politics += 1;
            Politics.sprite = Politics1[Score_Icon_Politics];
        }




        /*   if (RandomLaw.ChekChislo == 1 & Score_Icon_Spiritu > 0)
           {
               Score_Icon_Spiritu -= 1;
               Spiritu.sprite = Spiritu1[Score_Icon_Spiritu];
           }
           if (RandomLaw.ChekChislo == 4 & Score_Icon_Social > 0)
           {
               Score_Icon_Social -= 1;
               Social.sprite = Social1[Score_Icon_Social];
           }
           if (RandomLaw.ChekChislo == 3 & Score_Icon_Economy > 0)
           {
               Score_Icon_Economy -= 1;
               Economy.sprite = Economy1[Score_Icon_Economy];
           }
           if (RandomLaw.ChekChislo == 2 & Score_Icon_Politics > 0)
           {
               Score_Icon_Politics -= 1;
               Politics.sprite = Politics1[Score_Icon_Politics];
           }
           else if ((Score_Icon_Economy | Score_Icon_Politics | Score_Icon_Social | Score_Icon_Spiritu) == 0)
           {
               SceneManager.LoadScene(0);
           }*/
        RandomLaw.ChekChislo = 0;
    }

    private void Start()
    {
        Switch_Status();
    }
}
