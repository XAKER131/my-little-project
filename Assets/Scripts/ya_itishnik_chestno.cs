using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ya_itishnik_chestno: MonoBehaviour 
{
    public void PressedStartLvl( int sceneID )    
{
        SceneManager.LoadScene(sceneID);
    	}

    public void PressedExit()    
{
        Application.Quit();
    	}

}
