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
    public string q16 = "How would you describe your work style?";
    public string q17 = "What techniques and tools do you use to keep yourself organized?";
    public string q18 = "What three words would your friends use to describe you?";
    public string q19 = "Tell me what you think are the qualities of a good leader.";
    public string q20 = "Who has impacted you the most in your life?";
    public string q21 = "Can you describe a time when your work was criticized?";
    public string q22 = "Give me an example of a time that you felt you went above and beyond the call of duty at work or in a class.";
    public string q23 = "If your supervisor asked you to do something that you disagreed with, what would you do?";
    public string q24 = "What can you do for us that other candidates can't?";
    public string q25 = "What would you do if you were given multiple tasks and had no way of finishing them all on time?";
    public string q26 = "Whats a time that you exercised leadership?";


    public string t1 = "Tip: Try not to tell your whole life story, focus on things like education and career history. If possible, focus on things relevant to the position you’re applying to. ";
    public string t2 = "Tip: Be honest but try not to come across as arrogant. Try to pull out strengths and traits that you haven’t discussed in other aspects of the interview";
    public string t3 = "Tip: They’re testing self-awareness and honesty. Say something you honestly struggle with but follow it up by saying how you work around is or are improving.";
    public string t4 = "Tip: There’s no real right answer to this, try to give a realistic career path for you. Make sure that you don’t imply you’ll be leaving the company any time soon.";
    public string t5 = "Tip: Focus on what the problem was and how you resolved it peacefully. Don’t talk bad about the individuals within the group.";
    public string t6 = "Tip: Focus only on the problems that arose because if the cultural differences, don’t bad mouth the other group members. Be sure to be able to talk about how you solved any problems.";
    public string t7 = "Tip: Be honest, but don’t make it seem as if everything must be exactly how you want it. People will be less likely to offer you a job if they think you’ll fit in the environment.";
    public string t8 = "Tip: The answer to this question depends greatly on the exact career field you’re entering. Be honest and talk about why you enjoy it, and the future of the field.";
    public string t9 = "Tip: Make sure to use an example in which you were successful. Talk about why the change is important but focus on your persuasive techniques. ";
    public string t10 = "Tip: Be honest, talk about something you’re interested in and why you like it. Try not to use an example an average person might find off-putting.";
    public string t11 = "Tip: Talk about a project you finished or position you got that you are proud of. Make sure to mention how you worked to achieve this and what you did afterwards.";
    public string t12 = "Tip: Try to use a real example, but make sure it is one you did successfully handle. Try not to talk bad about your previous employment, your interviewer will assume you’ll do the same at new employment.";
    public string t13 = "Tip: Use a real example, but make sure to not sound like it was directly your fault. Talk about how you moved forward or changed your goal.";
    public string t14 = "Tip: Make sure that you would listen to the other persons side and see if you can reach a compromise. Unless the disagreement is severe its more important that everyone is happy.";
    public string t15 = "Tip: There’s no real right answer here, maybe mention keeping everyone happy, setting clear goals, not micro managing, or come up with your own.";
    public string t16 = "Tip: Try to talk about how you like to communicate, work with your boss, if you prefer to work collaboratively or by yourself, etc.";
    public string t17 = "Tip: You should be able to give an honest response to this, some organizational tools include an effective calendar system, filing and labeling, etc.";
    public string t18 = "Tip: Be honest. Try to pull out strengths and traits you haven't discussed in other aspects of the interview";
    public string t19 = "Tip: Be honest. Try to focus on qualities that you would want your boss to have, or that you think you would have if you were the boss. ";
    public string t20 = "Tip: Try to talk about someone who is relevant to the role, like a previous employer or teacher. Make sure to focus on how they helped you in ways that are relevant to the job";
    public string t21 = "Tip: Try to give a real example. Talk about why they criticized the work, but don’t bad mouth them personally and try not to come off as indignant. Focus on how you moved forward past it.";
    public string t22 = "Tip: Be honest. Don’t lowball yourself but also don’t be too prideful. Focus on the project and why you going above and beyond led to the project being more successful.";
    public string t23 = "Tip: There’s no real right answer to this, make sure you don’t completely fold on your stance, but also make sure you don’t ignore what your supervisor wants.";
    public string t24 = "Tip: This is another time to push your strengths. Focus on strengths that you think other people might not have or use it as an opportunity to push strengths you haven’t got a chance to mention yet.";
    public string t25 = "Tip: There’s no real right answer to this, you probably want to say you would finish the biggest tasks first, and you should probably talk to your supervisor about it.";
    public string t26 = "Tip: Try and give a real example. Focus on how you led your group to a successful conclusion, and how you made sure everyone was happy and productive.";


    public string [] ezTips = new string[8];
    public string [] medTips = new string[8];
    public string [] hardTips = new string[8];

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

        ezTips[0] = t1;
        ezTips[1] = t2;
        ezTips[2] = t3;
        ezTips[3] = t4;
        ezTips[4] = t5;
        ezTips[5] = t6;
        ezTips[6] = t7;
        ezTips[7] = t8;

        //Load medium weighted questions

        medWeighted[0] = q9;
		medWeighted[1] = q10;
		medWeighted[2] = q11;
		medWeighted[3] = q12;
		medWeighted[4] = q13;
		medWeighted[5] = q14;
		medWeighted[6] = q15;
		medWeighted[7] = "temp";

        medTips[0] = t9;
        medTips[1] = t10;
        medTips[2] = t11;
        medTips[3] = t12;
        medTips[4] = t13;
        medTips[5] = t14;
        medTips[6] = t15;
        medTips[7] = "temp";

        //Load medium weighed questions
        hardWeighted[0] = "temp";
		hardWeighted[1] = "temp";
		hardWeighted[2] = "temp";
		hardWeighted[3] = "temp";
		hardWeighted[4] = "temp";
		hardWeighted[5] = "temp";
		hardWeighted[6] = "temp";
		hardWeighted[7] = "temp";

        hardTips[0] = "temp";
        hardTips[1] = "temp";
        hardTips[2] = "temp";
        hardTips[3] = "temp";
        hardTips[4] = "temp";
        hardTips[5] = "temp";
        hardTips[6] = "temp";
        hardTips[7] = "temp";
    }

}
