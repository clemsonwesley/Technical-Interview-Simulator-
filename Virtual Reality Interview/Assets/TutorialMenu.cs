using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using TMPro;


public class TutorialMenu : MonoBehaviour
{


    private int i;
	private HashSet<int> numbers = new HashSet<int>();
	private int [] timeSet = new int[5];
	private int counter = 1;
	float timerr = 0;

	public GameObject can;
	
   

	private float clipTimeAvg = 2.875f;
	//public AudioClip intro;
	

    //public GameObject intro;
    //public GameObject introSquare;

    
    

    // Use this for initialization
    void Start()
    {
        //TipsToggle.tipsOn = 0;
        

        
        i = 0;
    }

	

    // Update is called once per frame
    void Update()
    {

		
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            /*if (i == 0)
            {
                intro.SetActive(false);
                introSquare.SetActive(false);

            }*/

			//Reset timer for first question
			

            


		}
        if(OVRInput.GetDown(OVRInput.Button.Start))
        {
            if (Time.timeScale == 1.0f){
                Time.timeScale = 0.0f;
				can.SetActive(true);
				//source.Pause();
				}

            else{
                Time.timeScale = 1.0f;
				can.SetActive(false);
				//source.Play();
				}
        }

		
    }

	

   

    
}
