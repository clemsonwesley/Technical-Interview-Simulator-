using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*Script Info://
*
* Script will be used to fade Group 9 Logo in and out
* Also it will be used to manage sound bit music
*
*/
public class logoScript : MonoBehaviour {

	public Image logo;
	//public string loadNext;

	IEnumerator Start(){
	
		logo.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(2.5f);
		FadeOut();
		yield return new WaitForSeconds(2.5f);
		//SceneManager.LoadScene(loadNext);
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}


	void FadeIn(){
	
		logo.CrossFadeAlpha(1.0f, 1.5f, false);

	}

	void FadeOut(){
	
		logo.CrossFadeAlpha(0.0f, 2.5f, false);
	

	}


}
