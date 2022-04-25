using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformForce : MonoBehaviour
{
    public float forceJump;
    private int a;
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
        if(collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-5f, 4.5f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}