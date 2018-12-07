using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class animController : MonoBehaviour {

    public Animator anima;
    int animRand;
    private static System.Timers.Timer aTimer;

	// Use this for initialization
	void Start () {
        anima = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown("space"))
        {
            animRand = new System.Random().Next(1, 3);
            switch (animRand)
            {
                case 1:
                    anima.Play("man01_Idle01");
                    anima.Play("man01_Talk01");
                    
                    break;
                case 2:
                    anima.Play("man01_Talk02");
                    break;
            }
            
            
        }
    }
}
