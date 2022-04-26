using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject Heart1, Heart2, Heart3;

    private void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(false);
        Heart3.SetActive(true);
        health = 3;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone1"))
        {
            health -= 1;
        }
    }

    private void Update()
    {
        switch (health)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;

            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;

            case 0:
                SceneManager.LoadScene(2);
                break;
        }
    }
}
