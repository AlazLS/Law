using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    public static int Current_State_Spirituality = 2;
    public static int Current_State_Sociality = 2;
    public static int Current_State_Economy = 2;
    public static int Current_State_Politics = 2;

    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 5;
    [SerializeField] private float jumpForce = 5f;

    public Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;


    public static Hero Instance { get; set; }

    IEnumerator Return()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(4);
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        spriteRenderer.flipX = dir.x > 0f;
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
                StartCoroutine("Return");
        }
    }
}