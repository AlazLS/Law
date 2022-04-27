using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FalseLaw : MonoBehaviour
{
    [SerializeField] private Text SlovaText;
    [SerializeField] private string[] Slova;


    private void Start()
    {
        //SlovaText.text = Slova[Random.Range(0, Slova.Length)];

        if (Sprites.TagAcite == "Spirituality")
        {
            RandomLaw.ChekChislo = -1;
        }
        if (Sprites.TagAcite == "Politics")
        {
            RandomLaw.ChekChislo = -2;
        }
        if (Sprites.TagAcite == "Economy")
        {
            RandomLaw.ChekChislo = -3;
        }
        if (Sprites.TagAcite == "Sociality")
        {
            RandomLaw.ChekChislo = -4;
        }

        WordGenerationPlatform2.EconomyForce = 0;
        WordGenerationPlatform3.SocialityForce = 0;
        WordGenerationPlatform4.SpiritualitForce = 0;
        WordGenerationPlatform5.PoliticsForce = 0;
    }
}
