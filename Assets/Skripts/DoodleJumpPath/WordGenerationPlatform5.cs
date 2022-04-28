using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordGenerationPlatform5 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;
    public static int PoliticsForce = 0;


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
                PoliticsForce += 1;
                if (PoliticsForce == 10 & Sprites.TagAcite == "Politics")
                {
                    SceneManager.LoadScene(3);
                }
                else if(PoliticsForce == 10 & Sprites.TagAcite != "Politics")
                {
                    SceneManager.LoadScene(4);
                }
            }
        }
    }
}
