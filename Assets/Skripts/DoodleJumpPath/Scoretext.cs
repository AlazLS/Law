using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoretext : MonoBehaviour
{
    public Text Score;

    private void Update()
    {
        if (Sprites.TagAcite == "Economy")
        {
            Score.text = WordGenerationPlatform2.EconomyForce.ToString() + "/10";
        }
        if (Sprites.TagAcite == "Sociality")
        {
            Score.text = WordGenerationPlatform3.SocialityForce.ToString() + "/10";
        }
        if (Sprites.TagAcite == "Spirituality")
        {
            Score.text = WordGenerationPlatform4.SpiritualitForce.ToString() + "/10";
        }
        if (Sprites.TagAcite == "Politics")
        {
            Score.text = WordGenerationPlatform5.PoliticsForce.ToString() + "/10";
        }
    }
}
