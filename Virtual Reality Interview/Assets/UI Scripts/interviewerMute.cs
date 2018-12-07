using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interviewerMute : MonoBehaviour {


	public static int voiceOn;
	public static int textOn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleVOn(){
	
		voiceOn = 0;

	}

	public void toggleVOff(){
	
		voiceOn = 1;

	}

	public void toggleTextOn(){
	
		textOn = 0;

	}

	public void toggleTextOff(){
	
		textOn = 1;

	}
}
