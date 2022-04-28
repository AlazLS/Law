using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformForce : MonoBehaviour
{
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.relativeVelocity.y < 0)
        {
            Hero.Instance.rigidbody.velocity = Vector2.up * forceJump;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "DeadZone1")
        {
            float RandX = Random.Range(-5f, 4.5f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector3(RandX, RandY, 0);

        }
    }
}