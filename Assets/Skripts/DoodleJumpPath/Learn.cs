using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Learn : MonoBehaviour
{
    [SerializeField] private Text SlovaText;
    [SerializeField] private string[] Slova;

    private void Start()
    {
        if (Sprites.TagAcite == "Spirituality")
        {
            SlovaText.text = Slova[0];
        }
        if (Sprites.TagAcite == "Sociality")
        {
            SlovaText.text = Slova[1];
        }
        if (Sprites.TagAcite == "Economy")
        {
            SlovaText.text = Slova[2];
        }
        if (Sprites.TagAcite == "Politics")
        {
            SlovaText.text = Slova[3];
        }
    }
}
