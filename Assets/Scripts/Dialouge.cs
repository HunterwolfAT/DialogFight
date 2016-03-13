using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dialouge {

	public Dictionary<string, Stage> stages = new Dictionary<string, Stage>();

	// Use this for initialization
	public Dialouge () {
		string line = "Hey...";
		stages.Add("Start", 
			new Stage(-1, line, "I'm, sorry.",
			// ========= Answers
			"Hey.", 
			null,
			null,
			null, 
			// ========= Keys
			"We need to talk.",
            null,
            //"", // WIN!
            null,
            null));

        line = "The call has ended.";
        stages.Add(line,
            new Stage(0, "The call has ended.", "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "We need to talk.";
		stages.Add(line, 
			new Stage(1, line, "We should have a long time ago.",
                // ========= Answers
                "Go ahead.",
                "How are you feeling?",
                "I don't think we do.", 
				null,
                // ========= Keys
                "When did it happen?",
                "I'm feeling a lot. Confused, mostly.",
                "I deserve answers.", 
				null));

        line = "When did it happen?";
        stages.Add(line,
            new Stage(1, line, "Only realized it some time ago.",
                // ========= Answers
                "Always been this way.",
                "Does it matter?",
                "What do you think?",
                null,
                // ========= Keys
                "No it hasn't.",
                "It matters to me!",
                "What? Do you think this is a game?",
                null));

        line = "No it hasn't.";
        stages.Add(line,
            new Stage(1, line, "That's why we had to split ways.",
                // ========= Answers
                "I'm sorry.",
                "(Hang up)",
                "You're right.",
                null,
                // ========= Keys
                "Tell me why you did this.",
                "The call has ended.",
                "Tell me why you did this.",
                null));

        line = "It matters to me!";
        stages.Add(line,
            new Stage(1, line, "But it isn't about you.",
                // ========= Answers
                "Let me explain.",
                "I don't care.",
                "(Hang up)",
                null,
                // ========= Keys
                "Okay. Here is your chance then.",
                "I tried understanding. Fuck you.",
                "The call has ended.",
                null));

        line = "I tried understanding. Fuck you.";
        stages.Add(line,
            new Stage(0, line, "You have not.",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The call has ended.",
                null,
                null,
                null));

        line = "Okay. Here is your chance then.";
        stages.Add(line,
            new Stage(0, line, "...",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Tell me why you did this.",
                null,
                null,
                null));

        line = "What? Do you think this is a game?";
        stages.Add(line,
            new Stage(1, line, "Nothing has been more serious.",
                // ========= Answers
                "Let me explain.",
                "I don't care.",
                "(Hang up)",
                null,
                // ========= Keys
                "Okay. Here is your chance then.",
                "I tried understanding. Fuck you.",
                "The call has ended.",
                null));

        line = "I deserve answers.";
        stages.Add(line,
            new Stage(1, line, "We both do.",
                // ========= Answers
                "Yes you do.",
                "Too bad.",
                null,
                null,
                // ========= Keys
                "Don't tell me what I deserve.",
                "What? Do you think this is a game?",
                null,
                null));

        line = "I'm feeling a lot. Confused, mostly.";
        stages.Add(line,
            new Stage(1, line, "Now you know how it was for me.",
                // ========= Answers
                "Well, me, I have never felt better.",
                "And angry, probably?",
                "I'm sorry.",
                null,
                // ========= Keys
                "Well, ain't that just amazing.",
                "Yes, also very angry.",
                "I deserve answers.",
                null));

        line = "Well, ain't that just amazing.";
        stages.Add(line,
            new Stage(1, line, "Why did I say that.",
                // ========= Answers
                "Actually, I'm sorry.",
                "I agree!",
                null,
                null,
                // ========= Keys
                "Why should I believe you now?",
                "Well, then sorry for bothering you.",
                null,
                null));

        line = "Why should I believe you now?";
        stages.Add(line,
            new Stage(1, line, "Shit...",
                // ========= Answers
                "Let's start over... how are you feeling?",
                "Because it-- I've always been this way.",
                null,
                null,
                // ========= Keys
                "Urgh. Fine.",
                "No it hasn't.",
                null,
                null));

        line = "Urgh. Fine.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "I deserve answers.",
                null,
                null,
                null));

        line = "Well, then sorry for bothering you.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Have a nice day. And fuck you.",
                null,
                null,
                null));

        line = "Have a nice day. And fuck you.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The call has ended.",
                null,
                null,
                null));

        line = "Yes, also very angry.";
        stages.Add(line,
            new Stage(1, line, "It's nobody's fault.",
                // ========= Answers
                "And you deserve to be.",
                "What do you want from me now?",
                "It has nothing to do with you.",
                null,
                // ========= Keys
                "Don't tell me what I deserve.",
                "Tell me why you did this.",
                "Please. Tell me more about that.",
                null));

        line = "Please. Tell me more about that.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                "It wouldn't help.",
                "Uh... it just doesn't?",
                null,
                null,
                // ========= Keys
                "I deserve answers.",
                "I tried understanding. Fuck you.",
                null,
                null));

        line = "Don't tell me what I deserve.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Tell me why you did this.",
                null,
                null,
                null));

        // ***************************************************************ACT2

        line = "Tell me why you did this.";
        stages.Add(line,
            new Stage(2, line, "Because I was made to lie to myself.",
                // ========= Answers
                "This is who I am.",
                "I don't owe you anything.",
                "You made me do it.",
                null,
                // ========= Keys
                "Then who was I in a relationship with?",
                "We have been together for years!",
                "No.",
                null));

        line = "Then who was I in a relationship with?";
        stages.Add(line,
            new Stage(3, line, "I'm still here.",
                // ========= Answers
                "They left and didn't come back.",
                "I shouldn't have disappeared like that.",
                "That person was never actually happy.",
                null,
                // ========= Keys
                "(You hear crying)",
                "I had forgiven before. Now I'm not sure.",
                "(You hear crying)",
                null));

        line = "(You hear crying)";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "You never truly loved me, didn't you?",
                null,
                null,
                null));

        line = "You never truly loved me, didn't you?";
        stages.Add(line,
            new Stage(3, line, "I did.",
                // ========= Answers
                "That's not true.",
                "No, I didn't.",
                "Did you truly love me?",
                "I don't know.",
                // ========= Keys
                "Then what is true?",
                "(You hear more crying)",
                "Don't avoid the question!",
                "Oh that's just great. Good answer."));

        line = "Then what is true?";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "(You hear more crying)";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "Don't avoid the question!";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Of course I fucking did.",
                null,
                null,
                null));

        line = "Of course I fucking did.";
        stages.Add(line,
            new Stage(1, line, "We should have talked about it.",
                // ========= Answers
                "I still care for you.",
                "Sucks.",
                "I love you.",
                null,
                // ========= Keys
                "Why didn't you call? Or write then?",
                "(You hear esasperated noises)",
                "I don't love you.",
                null));


        line = "Oh that's just great. Good answer.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "I don't love you.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "I don't even know you. I'm sorry. Bye.",
                null,
                null,
                null));

        line = "I don't even know you. I'm sorry. Bye.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The call has ended.",
                null,
                null,
                null));

        line = "Why didn't you call? Or write then?";
        stages.Add(line,
            new Stage(1, line, "It hurt too much.",
                // ========= Answers
                "I forgot...",
                "Nothing about this was easy.",
                null,
                null,
                // ========= Keys
                "Oh, of course. That explains everything!",
                "Leaving me sure SEEMED easy.",
                null,
                null));

        line = "Oh, of course. That explains everything!";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "You're clearly not up for talking. See you later.",
                null,
                null,
                null));

        line = "You're clearly not up for talking. See you later.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The call has ended.",
                null,
                null,
                null));

        line = "Leaving me sure SEEMED easy.";
        stages.Add(line,
            new Stage(1, line, "It felt right at the time.",
                // ========= Answers
                "It was the hardest thing in my life.",
                "You didn't make it hard.",
                "You saw why I had to.",
                null,
                // ========= Keys
                "*sigh* You are somebody else now anyway.",
                "(You hear esasperated noises)",
                "I... I guess.",
                null));

        line = "I... I guess";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "*sigh* You are somebody else now anyway.",
                null,
                null,
                null));

        line = "(You hear esasperated noises)";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Fuck you.",
                null,
                null,
                null));

        line = "Fuck you.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The call has ended.",
                null,
                null,
                null));

        line = "*sigh* You are somebody else now anyway.";
        stages.Add(line,
            new Stage(1, line, "Not at all.",
                // ========= Answers
                "I'm still me.",
                "Maybe. We were apart for a while.",
                "For you I am.",
                null,
                // ========= Keys
                "...I don't... I'm sorry.",
                "That's not what I-- don't toy with me.",
		null,
		null));

        line = "That's not what I-- don't toy with me.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "...I don't... I'm sorry.",
                null,
                null,
                null));

        line = "...I don't... I'm sorry.";
        stages.Add(line,
            new Stage(1, line, "We all made mistakes.",
                // ========= Answers
                "Thank you.",
                "I understand. This is not the first time.",
                null,
                null,
                // ========= Keys
		        "I.. I want to apologize.",
		        "I.. I want to apologize.",
                null,
                null));
/*
        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        line = "";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));
                */

	// ======================================== ACT 3

        line = "I.. I want to apologize.";
        stages.Add(line,
            new Stage(1, line, "...thank you.",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));

        // TEMPLATE STAGE....... Also the WIN stage
        line = "";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                null,
                null,
                null,
                null));
    }
}
