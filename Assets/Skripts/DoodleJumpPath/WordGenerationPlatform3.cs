using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordGenerationPlatform3 : MonoBehaviour
{
    [SerializeField] private TextMesh SlovaText;
    [SerializeField] private string[] Slova;
    public static int SocialityForce = 0;


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
                SocialityForce += 1;
                if (SocialityForce > 7)
                {
                    SceneManager.LoadScene(3);
                }
                print($"Sociality: {SocialityForce}");
            }
        }
    }
}
