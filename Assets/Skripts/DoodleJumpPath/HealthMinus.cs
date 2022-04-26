using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMinus : MonoBehaviour
{
    private int health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DeadZone")
        {
            health -= 1;
        }
        if(health == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

}
