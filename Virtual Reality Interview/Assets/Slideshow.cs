using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour {


    public Sprite[] Slides;
	public GameObject Slider;

	public int i;

    // Use this for initialization
    void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {

	if (OVRInput.GetDown(OVRInput.Button.One)) {
		
		Slider.GetComponent<SpriteRenderer>().sprite = Slides[i];

		//SpriteRenderer.sprite = Slides[i];
		i++;

		i = i % 27;

	}

	}
		
	
}
