using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class animController : MonoBehaviour {

    public Animator anim;
    System.Random rnd = new System.Random();
    int animRand;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown("space"))
        {
            animRand = rnd.Next(1, 3);
            switch (animRand)
            {
                case 1:
                    anim.Play("man01_Talk01");
                    break;
                case 2: anim.Play("man01_Talk02");
                    break;
            }
            
        }

		
	}
}
