using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerationPlatform5 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;

    private void Start()
    {
        SlovaText.text = Slova[Random.Range(0, Slova.Length)];
    }
}
