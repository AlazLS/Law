using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swap : MonoBehaviour
{
    private Animator _Swap;
    public bool firstAnimInclude = true;

    IEnumerator Scene_delay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("DoodleJump");
    }


    void Start()
    {
        _Swap = GetComponent<Animator>();
    }

    void Update()
    {
        if (firstAnimInclude) {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _Swap.Play("SwapLeft");
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _Swap.Play("SwapRigth");
                StartCoroutine(Scene_delay());
            }
        }
    }
}