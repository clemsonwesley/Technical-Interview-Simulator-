using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialougeAdvance : MonoBehaviour
{

    public Text myText;
    private int tipsOn = 0;
    private int i;
	private HashSet<int> numbers = new HashSet<int>();
	private int counter = 1;
	
    private string[] questions = { "Interviewer: Tell me about yourself?",
								   "Interviewer: What would you say is your greatest strength?",
                                   "Interviewer: What do you see as your greatest weakness?",
                                   "Interviewer: What are your long term career goals?",
                                   "Interviewer: Explain a time when you had a conflict within a group and how you solved it?",
								   "Interviewer: Talk about a time you worked with a group of culturally different people and what were the challenges you faced?",
								   "Interviewer: What type of group dynamic do you prefer in a professional setting?",
								   "Interviewer: Why do you want to be in this career field?"};

    private string[] tips = { "Tip: Try not to tell your whole life story, focus on things like education and career history. If possible focus on things relevant to the position you're applying to",
                                   "Tip: Focus on how you handled the situation professionally and productively, and ideally closing with a happy ending",
                                   "Tip: Be honest. Try to pull out strengths and traits you haven't discussed in other aspects of the interview",
                                   "Tip: They're testing self-awareness and honesty. Say something you honestly struggle with but follow it up by saying how you work around it or are improving.",
                                   "Tip: Dont lowball yourself, but try to be acurate, stay relevant to the job your interviewing for, and try to not be too vauge",
								   "Tip: Placeholder",
								   "Tip: Placeholder",
								   "Tip: Placeholder"};
    public AudioClip interview1;
    public AudioClip interview2;
    public AudioClip interview3;
    public AudioClip interview4;
    public AudioClip interview5;
	public AudioClip interview6;
	public AudioClip interview7;
	public AudioClip Interview8;

    public GameObject intro;
    public GameObject introSquare;

    private AudioSource source;
	public GameObject can;
    

    // Use this for initialization
    void Start()
    {
        tipsOn = 0;
        source = GetComponent<AudioSource>();

        myText.text = "";
        i = 0;
    }

	

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("t") && i == 0)
        {
            if (tipsOn == 0)
            {
                myText.text = "Tips enabled";
                tipsOn = 1;
            }
            else
            {
                myText.text = "Tips disabled";
                tipsOn = 0;
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (i == 0)
            {
                intro.SetActive(false);
                introSquare.SetActive(false);

            }

            myText.text = "";

            StartCoroutine("Dialouge");
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

		//Interview stopper statement -- end
		if (counter == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
			yield return new WaitForSeconds(1);
        }
        if (i < 8 && tipsOn == 1)
        {
            myText.text = tips[i];
        }

		i = Random.Range(0,7);
		while(numbers.Contains(i)){
			i = Random.Range(0,7);
			//Debug.Log(i);
		}
		numbers.Add(i);

        if (i < 8)
        {
            myText.text = questions[i];
        }
        if (i == 0) { source.PlayOneShot(interview1, 1);
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
		

		counter++;
        //yield return new WaitForSeconds(5f);
        
        

    }
}
