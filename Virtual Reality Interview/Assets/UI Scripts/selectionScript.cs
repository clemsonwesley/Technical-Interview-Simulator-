using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class selectionScript : MonoBehaviour {


	public Button selectBtn;
	// Use this for initialization
	void Start(){
	
		if(selectBtn != null){
			selectBtn.Select();
			//selectBtn.OnSubmit();
		
		}

	}
		
}
