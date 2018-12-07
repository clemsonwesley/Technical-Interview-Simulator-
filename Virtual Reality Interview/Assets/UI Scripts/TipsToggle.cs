using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsToggle : MonoBehaviour {

	public static int tipsOn;

	// Use this for initialization
	void Start () {
		tipsOn = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void turnOnTips(){
	
		tipsOn = 1;

	}

	public void turnOffTips(){
	
		tipsOn = 0;

	}
}
