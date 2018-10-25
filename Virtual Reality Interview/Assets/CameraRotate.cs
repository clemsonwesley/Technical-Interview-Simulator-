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
			transform.Rotate(Vector3.up, 20.0f * Time.deltaTime);	
        }
		if (Input.GetKeyDown("s"))
        {
			transform.Rotate(Vector3.right, 20.0f * Time.deltaTime);	
        }
		if (Input.GetKeyDown("w"))
        {
			transform.Rotate(Vector3.left, 20.0f * Time.deltaTime);	
        }
		if (Input.GetKeyDown("a"))
        {
			transform.Rotate(Vector3.down, 20.0f * Time.deltaTime);	
        }
		
	}
}
