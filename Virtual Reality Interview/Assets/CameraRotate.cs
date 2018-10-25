using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("d"))
        {
			transform.Rotate(Vector3.up, 90.0f);	
        }
		if (Input.GetKeyDown("s"))
        {
			transform.Rotate(Vector3.right, 90.0f);	
        }
		if (Input.GetKeyDown("w"))
        {
			transform.Rotate(Vector3.left, 90.0f);	
        }
		if (Input.GetKeyDown("a"))
        {
			transform.Rotate(Vector3.down, 90.0f);	
        }
		
	}
}
