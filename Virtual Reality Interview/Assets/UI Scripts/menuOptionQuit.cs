using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuOptionQuit : MonoBehaviour {

	public void QuitGame(){
		Debug.Log("Player has quit the game.");
		Application.Quit();
	}
}
