using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeDetection : MonoBehaviour {

	public UnityEngine.UI.Button btn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GazeEnter()
	{
	
		btn.Select();

	}

	public void GazeExit()
	{
	
		//Debug.Log("Exit");

	}
}
