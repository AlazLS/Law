using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomLaw : MonoBehaviour
{
    [SerializeField] private Text SlovaText;
    [SerializeField] private string[] Slova;
    public static int ChekChislo;

    public void RandL()
    {
        if (WordGenerationPlatform4.SpiritualitForce > (WordGenerationPlatform3.SocialityForce & WordGenerationPlatform2.EconomyForce & WordGenerationPlatform5.PoliticsForce) & Sprites.TagAcite == "Spirituality")
        {
            SlovaText.text = Slova[Random.Range(0, 14)];
            ChekChislo = 1;
        }
        else if (WordGenerationPlatform5.PoliticsForce > (WordGenerationPlatform3.SocialityForce & WordGenerationPlatform4.SpiritualitForce & WordGenerationPlatform2.EconomyForce) & Sprites.TagAcite == "Politics")
        {
            SlovaText.text = Slova[Random.Range(15, 29)];
            ChekChislo = 2;
        }
        else if (WordGenerationPlatform2.EconomyForce > (WordGenerationPlatform3.SocialityForce & WordGenerationPlatform4.SpiritualitForce & WordGenerationPlatform5.PoliticsForce) & Sprites.TagAcite == "Economy")
        {
            SlovaText.text = Slova[Random.Range(30, 44)];
            ChekChislo = 3;
        }
        else if (WordGenerationPlatform3.SocialityForce > (WordGenerationPlatform2.EconomyForce & WordGenerationPlatform4.SpiritualitForce & WordGenerationPlatform5.PoliticsForce) & Sprites.TagAcite == "Sociality")
        {
            SlovaText.text = Slova[Random.Range(45, 59)];
            ChekChislo = 4;
        }
        else
        {
            SceneManager.LoadScene(4);
        }

        WordGenerationPlatform2.EconomyForce = 0;
        WordGenerationPlatform3.SocialityForce = 0;
        WordGenerationPlatform4.SpiritualitForce = 0;
        WordGenerationPlatform5.PoliticsForce = 0;
    }

    private void Start()
    {
        RandL();
    }
}