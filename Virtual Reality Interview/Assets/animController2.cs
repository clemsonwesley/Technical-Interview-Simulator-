using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class animController2 : MonoBehaviour {

    public Animator anima;
    int animRand;

    // Use this for initialization
    void Start () {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown("space"))
        {
            animRand = new System.Random().Next(1, 2);
            switch (animRand)
            {
                case 1:
                    anima.Play("man02_Talk01");
                    break;
            }
        }
    }
}
