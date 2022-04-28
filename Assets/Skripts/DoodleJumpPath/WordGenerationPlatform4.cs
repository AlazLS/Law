using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordGenerationPlatform4 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;
    public static int SpiritualitForce = 0;


    private void Start()
    {
        SlovaText.text = Slova[Random.Range(0, Slova.Length)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.relativeVelocity.y < 0)
            {
                SpiritualitForce += 1;
                if (SpiritualitForce == 10 & Sprites.TagAcite == "Spirituality")
                    SceneManager.LoadScene(3);
            }
            else if(SpiritualitForce == 10 & Sprites.TagAcite != "Spirituality")
            {
                SceneManager.LoadScene(4);
            }
        }
    }

}