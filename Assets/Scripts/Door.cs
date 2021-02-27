using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {
	private bool inZone = false;
   	private void OnTriggerEnter2D( Collider2D collision )	{
		inZone = true;
		Debug.Log("Вы у двери");
	}
	private void OnTriggerExit2D( Collider2D collision)	{
		inZone = false;
		Debug.Log("Вы ушли от двери");
	}

	public int scene;
	void Update() {  
	if (Input.GetKeyDown("space") && inZone)
        {
            print("space key was pressed");
            SceneManager.LoadScene(scene);
            }
    }
}