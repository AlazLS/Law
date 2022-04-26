using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sprites : MonoBehaviour
{
    Status Chek;
    private int swi;
    public string TagAcite = "";
    public Text Mytext;

    [Header("Image")]
    [SerializeField] private Image img;

    [Header("Sprites")]
    [SerializeField] private Sprite[] sprite;

    IEnumerator Limit()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

   

    public void ChangeSprites()
    {
        if (swi < 5) {

            img.sprite = sprite[Random.Range(0, sprite.Length)];
            swi++;

            if (img.sprite == sprite[0])
            {
                Mytext.text = "я учЄный";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[1])
            {
                Mytext.text = "я политик";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[2])
            {
                Mytext.text = "я военный";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[3])
            {
                Mytext.text = "я агент";
            }
            if (img.sprite == sprite[4])
            {
                Mytext.text = "я домохоз€йка";
            }
        }
        else
        {
            StartCoroutine(Limit());
            swi = 0;
        }
    }
}