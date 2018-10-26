using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class fullScreenSprite : MonoBehaviour {

	// Use this for initialization
	void Start(){
	
	}

	void Update(){

		string str = EventSystem.current.currentSelectedGameObject.name;
		if(Input.GetKeyDown("space") && str == "StartButton"){
		   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else if(Input.GetKeyDown("space") && str == "ExitButton"){
			Debug.Log("Player has quit the game.");
			Application.Quit();
		}
	}
}
