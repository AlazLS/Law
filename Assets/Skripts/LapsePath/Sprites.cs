using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sprites : MonoBehaviour
{
    private int swi = 5;
    public static string TagAcite;
    public Text Mytext;
    public Text CoreText;

    [Header("Image")]
    [SerializeField] private Image img;

    [Header("Sprites")]
    [SerializeField] private Sprite[] sprite;

    IEnumerator Limit()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

   

    public void ChangeSprites()
    {
        if (swi > 0) {

            img.sprite = sprite[Random.Range(0, sprite.Length)];
            swi -= 1;
            CoreText.text = swi + "/5";

            if (img.sprite == sprite[0])
            {
                Mytext.text = "Фондовый рынок растет!!! Попробуйте использовать это!";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[1])
            {
                Mytext.text = "Вы заметили рост цен? С эти нужно что-то делать…";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[2])
            {
                Mytext.text = "Нам нужно срочно предотвратить экономический кризис";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[3])
            {
                Mytext.text = "Люди нуждаются в изменениях, мы можем им их дать.";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[4])
            {
                Mytext.text = "Я думаю, было бы замечательно поднять уровень жизни простых граждан";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[5])
            {
                Mytext.text = "Области социальной сферы общества нуждаются в реформах.";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[6])
            {
                Mytext.text = "Кхм.. кхм.. неплохо было бы принять, несколько небольших реформ.";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[7])
            {
                Mytext.text = "Нам нужен закон для  более тесного контакта с мировым сообществом.";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[8])
            {
                Mytext.text = "Мы должны принять несколько законов для сдерживания агрессии вражеских стран.";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[9])
            {
                Mytext.text = "В стране наблюдается упадок культуры и ценностей это нужно срочно решать.";
                TagAcite = "Spirituality";
            }
            if (img.sprite == sprite[10])
            {
                TagAcite = "Spirituality";
                Mytext.text = "Люди все меньше задумываются о своих действиях, так не пойдёт.";
            }
            if (img.sprite == sprite[11])
            {
                Mytext.text = "Нам нужно сделать так, чтобы люди чаще улыбались";
                TagAcite = "Spirituality";
            }
        }
        else
        {
            StartCoroutine(Limit());
            swi = 0;
        }
    }
}