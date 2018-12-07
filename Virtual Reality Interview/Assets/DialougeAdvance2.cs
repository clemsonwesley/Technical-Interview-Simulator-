using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using TMPro;


public class DialougeAdvance2 : MonoBehaviour
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
	
    private string[] questions = { "Interviewer: What techniques and tools do you use to keep yourself organized?",
								   "Interviewer: What three words would your friends use to describe you?",
                                   "Interviewer: Tell me what you think are the qualities of a good leader.",
                                   "Interviewer: Who has impacted you the most in your life?",
                                   "Interviewer: Can you describe a time when your work was criticized?",
								   "Interviewer: Give me an example of a time that you felt you went above and beyond the call of duty at work or in a class.",
								   "Interviewer: If your supervisor asked you to do something that you disagreed with, what would you do?",
								   "Interviewer: What can you do for us that other candidates can't?"};

    private string[] tips = { "Tip: You should be able to give an honest response to this, some organizational tools include an effective calendar system, filing and labeling, etc.",
                                   "Tip: Be honest. Try to pull out strengths and traits you haven't discussed in other aspects of the interview",
                                   "Tip: Be honest. Try to focus on qualities that you would want your boss to have, or that you think you would have if you were the boss. ",
                                   "Tip: Try to talk about someone who is relevant to the role, like a previous employer or teacher. Make sure to focus on how they helped you in ways that are relevant to the job",
                                   "Tip: Try to give a real example. Talk about why they criticized the work, but don’t bad mouth them personally and try not to come off as indignant. Focus on how you moved forward past it.",
								   "Tip: Be honest. Don’t lowball yourself but also don’t be too prideful. Focus on the project and why you going above and beyond led to the project being more successful.",
								   "Tip: There’s no real right answer to this, make sure you don’t completely fold on your stance, but also make sure you don’t ignore what your supervisor wants.",
								   "Tip: This is another time to push your strengths. Focus on strengths that you think other people might not have or use it as an opportunity to push strengths you haven’t got a chance to mention yet."};

	

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
