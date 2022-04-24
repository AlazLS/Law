using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
{

    public GameObject Representative;
    public GameObject Name;
    public GameObject Tap_To_Start;
    public GameObject ULapse;
    public GameObject Icons;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Name.SetActive(false);
            Tap_To_Start.SetActive(false);
            ULapse.SetActive(true);
            Icons.SetActive(true);
            Representative.SetActive(true);
        }
    }
}