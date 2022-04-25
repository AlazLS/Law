using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllRigth : MonoBehaviour
{
	IEnumerator Rigth()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(1);
	}

	public void ChangeScene(string sceneName)
	{
		StartCoroutine("Rigth");
	}
}
