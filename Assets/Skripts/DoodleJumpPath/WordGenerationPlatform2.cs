using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordGenerationPlatform2 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;
    public static int EconomyForce = 0;


    private void Start()
    {
        EconomyForce = 0;
        SlovaText.text = Slova[Random.Range(0, Slova.Length)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.relativeVelocity.y < 0)
            {
                EconomyForce += 1;
                if (EconomyForce > 7)
                {
                    SceneManager.LoadScene(3);
                }
                print($"Economy: {EconomyForce}");
            }
        }
    }
}
