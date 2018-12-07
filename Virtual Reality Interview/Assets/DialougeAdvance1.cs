using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using TMPro;


public class DialougeAdvance1 : MonoBehaviour
{

    public Text myText;
	public TextMeshProUGUI time1;
	public TextMeshProUGUI time2;
	public TextMeshProUGUI time3;
	public TextMeshProUGUI time4;
	public TextMeshProUGUI time5;
	public TextMeshProUGUI time6;
	public TextMeshProUGUI time7;
	public TextMeshProUGUI time8;
	public TextMeshProUGUI time9;
	public TextMeshProUGUI time10;

    private int i;
	private HashSet<int> numbers = new HashSet<int>();
	private int [] timeSet = new int[5];
	private int counter = 1;
	float timerr = 0;
	
    private string[] questions = { "Interviewer: Tell me about a time you had to persuade a group of people to make a big change?",
								   "Interviewer: What are some of your hobbies outside your professional career?",
                                   "Interviewer: Give an example of a goal you reached and tell me how you handled it?",
                                   "Interviewer: Describe a stressfull situation at work and how you handled it?",
                                   "Interviewer: Did you ever not meet your goals?",
								   "Interviewer: What do you do if you and your co-worker disagree on a pivotal task?",
								   "Interviewer: What is your best strategy to motivate your teammates?",
								   "Interviewer: How would you describe your work style?"};

    private string[] tips = { "Tip: Make sure to use an example in which you were successful. Talk about why the change is important but focus on your persuasive techniques. ",
                                  "Tip: Be honest, talk about something you’re interested in and why you like it. Try not to use an example an average person might find off-putting.",
                                   "Tip: Talk about a project you finished or position you got that you are proud of. Make sure to mention how you worked to achieve this and what you did afterwards.",
                                   "Tip: Try to use a real example, but make sure it is one you did successfully handle. Try not to talk bad about your previous employment, your interviewer will assume you’ll do the same at new employment.",
                                   "Tip: Use a real example, but make sure to not sound like it was directly your fault. Talk about how you moved forward or changed your goal.",
								   "Tip: Make sure that you would listen to the other persons side and see if you can reach a compromise. Unless the disagreement is severe its more important that everyone is happy.",
								   "Tip: There’s no real right answer here, maybe mention keeping everyone happy, setting clear goals, not micro managing, or come up with your own.",
								   "Tip: Try to talk about how you like to communicate, work with your boss, if you prefer to work collaboratively or by yourself, etc."};

	

    public AudioClip interview1;
    public AudioClip interview2;
    public AudioClip interview3;
    public AudioClip interview4;
    public AudioClip interview5;
	public AudioClip interview6;
	public AudioClip interview7;
	public AudioClip Interview8;

	private float clipTimeAvg = 2.875f;
	//public AudioClip intro;
	public AudioClip outro;

    //public GameObject intro;
    //public GameObject introSquare;

    private AudioSource source;
	public GameObject can;
	public GameObject can2;
    

    // Use this for initialization
    void Start()
    {
        //TipsToggle.tipsOn = 0;
        source = GetComponent<AudioSource>();

        myText.text = "";
        i = 0;
    }

	

    // Update is called once per frame
    void Update()
    {

		timerr += Time.deltaTime;
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            /*if (i == 0)
            {
                intro.SetActive(false);
                introSquare.SetActive(false);

            }*/

			//Reset timer for first question
			if(counter == 1){
				timerr = 0;
			}

            myText.text = "";

			if(counter >= 2){
			timerr -= clipTimeAvg;
			TimeSpan timespan = TimeSpan.FromSeconds((int)timerr);
			int min = timespan.Minutes;
			int sec = timespan.Seconds;
			
			if(counter == 2){
				time1.text = min.ToString();
				time6.text = sec.ToString();
			}
			if(counter == 3){
				time2.text = min.ToString();
				time7.text = sec.ToString();
			}
			if(counter == 4){
				time3.text = min.ToString();
				time8.text = sec.ToString();
			}
			if(counter == 5){
				time4.text = min.ToString();
				time9.text = sec.ToString();
			}
			if(counter == 6){
				time5.text = min.ToString();
				time10.text = sec.ToString();
			}

			//Debug.Log(min);
			//Debug.Log(sec);
			//timeSet[counter-2] = sec;
			timerr = 0;

		}

			if(counter < 6){
			
            StartCoroutine("Dialouge");
			}

			if(counter == 6){

				myText.text = "";
			//Debug.Log("Made it");
			source.PlayOneShot(outro, 1);
			Thread.Sleep(6);
				can2.SetActive(true);
			}
        }
        if(OVRInput.GetDown(OVRInput.Button.Start))
        {
            if (Time.timeScale == 1.0f){
                Time.timeScale = 0.0f;
				can.SetActive(true);
				source.Pause();
				}

            else{
                Time.timeScale = 1.0f;
				can.SetActive(false);
				source.Play();
				}
        }

		
    }

	

    IEnumerator Dialouge()
    {

		//Debug.Log(TipsToggle.tipsOn);
		//Interview stopper statement -- end

		
			
		if (counter == 6)
        {
            
			yield return new WaitForSeconds(1);
        }
        

		i = UnityEngine.Random.Range(0,7);
		while(numbers.Contains(i)){
			i = UnityEngine.Random.Range(0,7);
			//Debug.Log(i);
		}
		numbers.Add(i);

        if (i < 8)
        {
            myText.text = questions[i];
        }
        if (i == 0) { 
			//myText.text = "";
			//source.PlayOneShot(intro, 1);
			//Thread.Sleep(5);
			//myText.text = questions[i];
			source.PlayOneShot(interview1, 1);
            yield return new WaitForSeconds(interview1.length);
        }
        if (i == 1) { source.PlayOneShot(interview2, 1);
            yield return new WaitForSeconds(interview2.length);
        }
        if (i == 2) { source.PlayOneShot(interview3, 1);
            yield return new WaitForSeconds(interview3.length);
        }
        if (i == 3) { source.PlayOneShot(interview4, 1);
            yield return new WaitForSeconds(interview4.length);
        }
        if (i == 4) { source.PlayOneShot(interview5, 1);
            yield return new WaitForSeconds(interview5.length);
        }
		if (i == 5) { source.PlayOneShot(interview6, 1);
            yield return new WaitForSeconds(interview5.length);
        }
		if (i == 6) { source.PlayOneShot(interview7, 1);
            yield return new WaitForSeconds(interview5.length);
        }
		if (i == 7) { source.PlayOneShot(Interview8, 1);
            yield return new WaitForSeconds(interview5.length);
        }
		
		if (i < 8 && TipsToggle.tipsOn == 1)
        {
            myText.text = tips[i];
        }

		counter++;
        //yield return new WaitForSeconds(5f);
        
        

    }
}
