using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformForce : MonoBehaviour
{
    Health heal;
    public float forceJump;
    private int count = 3;
    private GameObject player;
    private GameObject[] platform;


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        platform = GameObject.FindGameObjectsWithTag("Sociality");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.relativeVelocity.y < 0)
        {
            Hero.Instance.rigidbody.velocity = Vector2.up * forceJump;

        }   
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.name == "DeadZone" && count > 0)
        {
            count -= 1;
            float RandX = Random.Range(-5f, 4.5f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector3(RandX, RandY, 0);
        }
        else if(count == 0)
        {
            count = 3;
            SceneManager.LoadScene(2);
        }
    }
}