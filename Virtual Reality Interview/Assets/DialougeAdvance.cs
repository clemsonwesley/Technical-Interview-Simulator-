using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeAdvance : MonoBehaviour
{

    public Text myText;
    private int i;
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
    public AudioClip logoFX;
    public Animator anim;
    private AudioSource source;
    

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        myText.text = "";
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            myText.text = "";
            source.PlayOneShot(logoFX, 1);
            anim.SetTrigger("basic motion");
            StartCoroutine("Dialouge");
        }
        if(Input.GetKeyDown("p"))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.0f;
            else
                Time.timeScale = 1.0f;
        }
    }

    IEnumerator Dialouge()
    {
 
        myText.text = questions[i];


        yield return new WaitForSeconds(5f);

        myText.text = tips[i];

        i++;

    }
}
