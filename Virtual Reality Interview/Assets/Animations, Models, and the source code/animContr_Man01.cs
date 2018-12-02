using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animContr_Man01 : MonoBehaviour {

    Animator anim;
    int animCount = 0;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
        {
            switch (animCount)
            {
                case 0 :
                    anim.Play("man01_Talk01");
                    animCount++;
                    break;

            }
        }
	}
}
