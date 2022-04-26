using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordGenerationPlatform4 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;
    private int SpiritualitForce = 0;


    private void Start()
    {
        SlovaText.text = Slova[Random.Range(0, Slova.Length)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SpiritualitForce++;
            if (SpiritualitForce > 7)
            {
                SceneManager.LoadScene(2);
            }
            else if (collision.relativeVelocity.y < 0)
            {
                print($"Spiritualit: {SpiritualitForce}");
            }
        }
    }
}
