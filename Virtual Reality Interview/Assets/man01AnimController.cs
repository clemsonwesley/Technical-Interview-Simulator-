using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man01AnimController : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
        {
            switch (animNum)
            {
                case 1:
                    anim.Play("man01_Talk01");
                    break;
            }
        }
	}
}
