using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TapToStart : MonoBehaviour
{

    public GameObject Representative;
    public GameObject Tap_To_Start;
    public GameObject ULapse;
    public GameObject Icons;
    public Button starButton;
    private Animator Appearence;


    private void Start()
    {
        Appearence = GetComponent<Animator>();
    }

    IEnumerator Appearen()
    {
        yield return new WaitForSeconds(2);
        Appearence.Play("AppearanceRep");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2);
        }
    }
}