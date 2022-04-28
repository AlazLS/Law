using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
	public void Change_Scene(string sceneName)
	{
		SceneManager.LoadScene(2);
	}

    private void Update()
    {
        Hero.Current_State_Spirituality = 2;
        Hero.Current_State_Sociality = 2;
        Hero.Current_State_Economy = 2;
        Hero.Current_State_Politics = 2;

        Status.Score_Icon_Economy = 3;
        Status.Score_Icon_Social = 3;
        Status.Score_Icon_Spiritu = 3;
        Status.Score_Icon_Politics = 3;
        
    }
}
