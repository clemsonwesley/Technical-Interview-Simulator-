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
	private int counter = 0;
	
    private string[] questions = { "Interviewer: Thank you for coming to see us for your interview today, why dont you go ahead and tell me a little about yourself?",
                                   "Interviewer: Well its good to meet you. This role would require good problem solving skills, can you outline an issue you've had in the past how you tackled it?",
                                   "Interviewer: If i asked your best friend what three words best described you, what do you think they would say?",
                                   "Interviewer: What would you say is your greatest weakness?",
                                   "Interviewer: And what would you say is your greatest strength?" };
    private string[] tips = { "Tip: Try not to tell your whole life story, focus on things like education and career history. If possible focus on things relevant to the position you're applying to",
                                   "Tip: Focus on how you handled the situation professionally and productively, and ideally closing with a happy ending",
                                   "Tip: Be honest. Try to pull out strengths and traits you haven't discussed in other aspects of the interview",
                                   "Tip: They're testing self-awareness and honesty. Say something you honestly struggle with but follow it up by saying how you work around it or are improving.",
                                   "Tip: Dont lowball yourself, but try to be acurate, stay relevant to the job your interviewing for, and try to not be too vauge" };
    public AudioClip interview1;
    public AudioClip interview2;
    public AudioClip interview3;
    public AudioClip interview4;
    public AudioClip interview5;

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

		if (counter == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (i < 5 && tipsOn == 1)
        {
            myText.text = tips[i];
        }

		i = Random.Range(0,4);
		while(numbers.Contains(i)){
			i = Random.Range(0,4);
			//Debug.Log(i);
		}
		numbers.Add(i);

        if (i < 5)
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

		counter++;
        //yield return new WaitForSeconds(5f);
        
        

    }
}
