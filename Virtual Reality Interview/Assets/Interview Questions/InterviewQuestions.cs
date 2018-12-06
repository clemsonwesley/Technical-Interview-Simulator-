using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterviewQuestions : MonoBehaviour {

	
	public string q1 = "Tell me about yourself?"; //ez
	public string q2 = "What do you see as your greatest strength?"; //ez
	public string q3 = "What do you see as your greatest weakness?"; //ez
	public string q4 = "What are your long term career goals?"; 
	public string q5 = "Explain a time when you had a conflict within a group and how you solved it?";
	public string q6 = "Talk about a time your worked with a group of culturally different people and what were the challenges you faced?";
	public string q7 = "What type of group dynamic do you prefer in a professional setting?";
	public string q8 = "Why do you want to be in this career field?";
	public string q9 = "Tell me about a time you had to persuade a group of people to make a big change?";
	public string q10 = "What are some of your hobbies outside your professional career?";
	public string q11 = "Give an example of a goal you reached and tell me how you handled it?";
	public string q12 = "Describe a stressfull situation at work and how you handled it?";
	public string q13 = "Did you ever not meet your goals?";
	public string q14 = "What do you do if you and your co-worker disagree on a pivotal task?";
	public string q15 = "What is your best strategy to motivate your teammates?";

	public string [] ezWeighted = new string[8];
	public string [] medWeighted = new string[8];
	public string [] hardWeighted = new string[8];

	public void storeStrings()
	{
	
		//Load easy weighted questions
		ezWeighted[0] = q1;
		ezWeighted[1] = q2;
		ezWeighted[2] = q3;
		ezWeighted[3] = q4;
		ezWeighted[4] = q5;
		ezWeighted[5] = q6;
		ezWeighted[6] = q7;
		ezWeighted[7] = q8;

		//Load medium weighted questions

		medWeighted[0] = q9;
		medWeighted[1] = q10;
		medWeighted[2] = q11;
		medWeighted[3] = q12;
		medWeighted[4] = q13;
		medWeighted[5] = q14;
		medWeighted[6] = q15;
		medWeighted[7] = "temp";

		//Load medium weighed questions
		hardWeighted[0] = "temp";
		hardWeighted[1] = "temp";
		hardWeighted[2] = "temp";
		hardWeighted[3] = "temp";
		hardWeighted[4] = "temp";
		hardWeighted[5] = "temp";
		hardWeighted[6] = "temp";
		hardWeighted[7] = "temp";

	}

}
