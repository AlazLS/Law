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
    public Text ResporName;

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
                Mytext.text = "�������� ����� ������!!! ���������� ������������ ���!";
                ResporName.text = "����������";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[1])
            {
                Mytext.text = "�� �������� ���� ���? � ��� ����� ���-�� �������";
                ResporName.text = "���������������";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[2])
            {
                Mytext.text = "��� ����� ������ ������������� ������������� ������";
                ResporName.text = "������������� ��������";
                TagAcite = "Economy";
            }
            if (img.sprite == sprite[3])
            {
                Mytext.text = "���� ��������� � ����������, �� ����� �� �� ����.";
                ResporName.text = "����";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[4])
            {
                Mytext.text = "� �����, ���� �� ������������ ������� ������� ����� ������� �������";
                ResporName.text = "��������";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[5])
            {
                Mytext.text = "������� ���������� ����� �������� ��������� � ��������.";
                ResporName.text = "���������";
                TagAcite = "Sociality";
            }
            if (img.sprite == sprite[6])
            {
                Mytext.text = "���.. ���.. ������� ���� �� �������, ��������� ��������� ������.";
                ResporName.text = "�������";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[7])
            {
                Mytext.text = "��� ����� ����� ���  ����� ������� �������� � ������� �����������.";
                ResporName.text = "���������";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[8])
            {
                Mytext.text = "�� ������ ������� ��������� ������� ��� ����������� �������� ��������� �����.";
                ResporName.text = "�������";
                TagAcite = "Politics";
            }
            if (img.sprite == sprite[9])
            {
                Mytext.text = "� ������ ����������� ������ �������� � ��������� ��� ����� ������ ������.";
                ResporName.text = "������-���������";
                TagAcite = "Spirituality";
            }
            if (img.sprite == sprite[10])
            {
                Mytext.text = "���� ��� ������ ������������ � ����� ���������, ��� �� �����.";
                ResporName.text = "��������";
                TagAcite = "Spirituality";
            }
            if (img.sprite == sprite[11])
            {
                Mytext.text = "��� ����� ������� ���, ����� ���� ���� ���������";
                ResporName.text = "�������";
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