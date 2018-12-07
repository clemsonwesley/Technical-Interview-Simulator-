using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vid : MonoBehaviour {


	public void PlayGame(){
		WaitForSeconds wait = new WaitForSeconds(3);
		SceneManager.LoadScene(4);
	}
}
