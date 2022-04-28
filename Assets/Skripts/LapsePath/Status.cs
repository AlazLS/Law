using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public static int Score_Icon_Economy = 2;
    public static int Score_Icon_Social = 2;
    public static int Score_Icon_Spiritu = 2;
    public static int Score_Icon_Politics = 2;

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

    IEnumerator Reaload()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(5);
    }

    public void Switch_Munis_Status()
    {
        if (RandomLaw.ChekChislo == -1 & Score_Icon_Spiritu > 0)
        {
            Score_Icon_Spiritu -= 1;
            Spiritu.sprite = Spiritu1[Score_Icon_Spiritu];
            Hero.Current_State_Spirituality = Score_Icon_Spiritu;
        }
        if (RandomLaw.ChekChislo == -4 & Score_Icon_Social > 0)
        {
            Score_Icon_Social -= 1;
            Social.sprite = Social1[Score_Icon_Social];
            Hero.Current_State_Sociality = Score_Icon_Social;
        }
        if (RandomLaw.ChekChislo == -3 & Score_Icon_Economy > 0)
        {
            Score_Icon_Economy -= 1;
            Economy.sprite = Economy1[Score_Icon_Economy];
            Hero.Current_State_Economy = Score_Icon_Economy;
        }
        if (RandomLaw.ChekChislo == -2 & Score_Icon_Politics > 0)
        {
            Score_Icon_Politics -= 1;
            Politics.sprite = Politics1[Score_Icon_Politics];
            Hero.Current_State_Politics = Score_Icon_Politics;
        }
    }

    public void Switch_Status()
    {
        if (RandomLaw.ChekChislo == 1 & Score_Icon_Spiritu <= 3)
        {
            Score_Icon_Spiritu += 1;
            Spiritu.sprite = Spiritu1[Score_Icon_Spiritu];
            Hero.Current_State_Spirituality = Score_Icon_Spiritu;
            RandomLaw.ChekChislo = 0;
        }
        if (RandomLaw.ChekChislo == 4 & Score_Icon_Social <= 3)
        {
            Score_Icon_Social += 1;
            Social.sprite = Social1[Score_Icon_Social];
            Hero.Current_State_Sociality = Score_Icon_Social;
            RandomLaw.ChekChislo = 0;
        }
        if (RandomLaw.ChekChislo == 3 & Score_Icon_Economy <= 3)
        {
            Score_Icon_Economy += 1;
            Economy.sprite = Economy1[Score_Icon_Economy];
            Hero.Current_State_Economy = Score_Icon_Economy;
            RandomLaw.ChekChislo = 0;
        }
        if (RandomLaw.ChekChislo == 2 & Score_Icon_Politics <= 3)
        {
            Score_Icon_Politics += 1;
            Politics.sprite = Politics1[Score_Icon_Politics];
            Hero.Current_State_Politics = Score_Icon_Politics;
            RandomLaw.ChekChislo = 0;
        }
    }

    private void Start()
    {
        
            Spiritu.sprite = Spiritu1[Hero.Current_State_Spirituality];
            Social.sprite = Social1[Hero.Current_State_Sociality];
            Economy.sprite = Economy1[Hero.Current_State_Economy];
            Politics.sprite = Politics1[Hero.Current_State_Politics];

            Switch_Status();
            Switch_Munis_Status();

            if (Score_Icon_Economy == 0 | Score_Icon_Politics == 0 | Score_Icon_Social == 0 | Score_Icon_Spiritu  == 0)
            {
                StartCoroutine("Reaload");
            }
    }
}