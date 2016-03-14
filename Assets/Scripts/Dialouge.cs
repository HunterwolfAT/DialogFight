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
                "What if I don't feel like talking.",
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

        line = "We have been together for years!";
        stages.Add(line,
            new Stage(0, line, "It felt too long.",
                // ========= Answers
                "I don't regret that.",
                null,
                null,
                null,
                // ========= Keys
                "Don't I deserve... something?",
                null,
                null,
                null));

        line = "Don't I deserve... something?";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "(You hear crying)",
                null,
                null,
                null));

        line = "No.";
        stages.Add(line,
            new Stage(0, line, "You're right.",
                // ========= Answers
                "Aren't you proud? Of yourself? Of me?",
                "Yes.",
                null,
                null,
                // ========= Keys
                "(You hear nothing.)",
                "Why would you say that? What did I do?",
                null,
                null));

        line = "(You hear nothing.)";
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

        line = "Why would you say that? What did I do?";
        stages.Add(line,
            new Stage(0, line, "You did nothing. I am lying.",
                // ========= Answers
                "You made me want to be somebody else.",
                "That's not really true.",
                "I didn't think you loved me.",
                null,
                // ========= Keys
                "Then who was I in a relationship with?",
                "Then what is true?",
                "Of course I fucking did.",
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
                "I had forgiven you. Now I'm not sure.",
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

        line = "I had forgiven you. Now I'm not sure.";
        stages.Add(line,
            new Stage(0, line, "Maybe I don't deserve it.",
                // ========= Answers
                "We weren't together for that long...",
                "I still love you.",
                null,
                null,
                // ========= Keys
                "We have been together for years!",
                "I don't love you.",
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
                "You don't know? That's just great."));

        line = "Then what is true?";
        stages.Add(line,
            new Stage(1, line, "Again, I'm sorry.",
                // ========= Answers
                "What I did is nobody's fault.",
                "I have always loved you.",
                "You are still important to me.",
                null,
                // ========= Keys
                "The running away or your changes?",
                "I don't love you.",
                "Why didn't you call? Or write then?",
                null));

        line = "The running away or your changes?";
        stages.Add(line,
            new Stage(0, line, "...",
                // ========= Answers
                "Both?",
                "The former IS your fault.",
                "I don't know.",
                null,
                // ========= Keys
                "Are you sure you are not to blame?",
                "(You hear more crying)",
                "You don't know? That's just great.",
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
                "Why would you say that? What did I do?",
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


        line = "You don't know? That's just great.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "The fine m..r...s... argh! Doesn't know!",
                null,
                null,
                null));

        line = "The fine m..r...s... argh! Doesn't know!";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Call me if one of them knows something!",
                null,
                null,
                null));

        line = "Call me if one of them knows something!";
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

        line = "I... I guess.";
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
                "That's not what I-- don't toy with me.",
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
                "I understand. It's not the first time.",
                null,
                null,
                // ========= Keys
		        "I.. I want to apologize.",
                "Are you really happier this way?",
                null,
                null));

        // *************************************************************** ACT 3

        line = "I.. I want to apologize.";
        stages.Add(line,
            new Stage(1, line, "Now we are on the same page.",
                // ========= Answers
                "Thank you.",
                "I'm sorry too.",
                "You don't have to.",
                null,
                // ========= Keys
                "Still, doesn't excuse what you've done.",
                "Are you really happier this way?",
                "Are you really happier this way?",
                null));

        line = "Still, doesn't excuse what you've done.";
        stages.Add(line,
            new Stage(0, line, "Regretted it enough.",
                // ========= Answers
                "I don't think it was wrong.",
                "I had to.",
                "Yeah, you're right.",
                null,
                // ========= Keys
                "I don't think you're being honest.",
                "You HAD to leave me crying for days?",
                "Are you really happier this way?",
                null));

        line = "You HAD to leave me crying for days?";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Oh, of course. That explains everything!",
                null,
                null,
                null));

        line = "I don't think you're being honest.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "That, or you're being really ignorant.",
                null,
                null,
                null));

        line = "That, or you're being really ignorant.";
        stages.Add(line,
            new Stage(0, line, "Probably.",
                // ========= Answers
                "What am I ignorant of?",
                "I used to. It's been quite a while.",
                null,
                null,
                // ========= Keys
                "(You hear esasperated noises)",
                "You sound really sure.",
                null,
                null));

        line = "You sound really sure.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Okay. Let's say I believe you.",
                null,
                null,
                null));

        line = "Okay. Let's say I believe you.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Are you really happier this way?",
                null,
                null,
                null));

        line = "Are you really happier this way?";
        stages.Add(line,
            new Stage(1, line, "The time with you was great too.",
                // ========= Answers
                "I'm better. I needed it.",
                null,
                null,
                null,
                // ========= Keys
                "That's good, I guess.",
                null,
                null,
                null));

        line = "That's good, I guess.";
        stages.Add(line,
            new Stage(1, line, "It is.", // 1 is intentional!
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "...Are you... all..?",
                null,
                null,
                null));

        line = "...Are you... all..?";
        stages.Add(line,
            new Stage(1, line, "Oh god, no.",
                // ========= Answers
                "What do you mean?",
                null,
                null,
                null,
                // ========= Keys
                "You know. Did you get surgery?",
                null,
                null,
                null));

        line = "You know. Did you get surgery?";
        stages.Add(line,
            new Stage(1, line, "I'm still sorry, but this is none of your business.",
                // ========= Answers
                "I am about to.",
                "Why does it matter to you.",
                "I don't think I will.",
                null,
                // ========= Keys
                "...I always liked how you were.",
                "First you make me ask...",
                "Kinda glad about that.",
                null));

        line = "Kinda glad about that.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "...I always liked how you were.",
                null,
                null,
                null));

        line = "...I always liked how you were.";
        stages.Add(line,
            new Stage(0, line, "I didn't.",
                // ========= Answers
                "It wasn't how I felt.",
                "I never belonged to you though.",
                "It's my body.",
                null,
                // ========= Keys
                "You never tried hard to fit in.",
                "First you make me ask...",
                "Calm down. I was only saying.",
                null));

        line = "You never tried hard to fit in.";
        stages.Add(line,
            new Stage(0, line, "You still don't get it?",
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
        
        line = "Calm down. I was only saying.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "First you make me ask...",
                null,
                null,
                null));

        line = "First you make me ask...";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "...then you get pissy.",
                null,
                null,
                null));

        line = "...then you get pissy.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Urgh, I don't want to deal with this.",
                null,
                null,
                null));

        line = "Urgh, I don't want to deal with this.";
        stages.Add(line,
            new Stage(1, line, "Sure, make it about you.",
                // ========= Answers
                "Nobody asked you to.",
                "Look, I'm sorry. It's a touchy subject.",
                null,
                null,
                // ========= Keys
                "I had to when you changed your body!",
                "Okay. Damn.",
                null,
                null));

        line = "I had to when you changed your body!";
        stages.Add(line,
            new Stage(0, line, "Please calm down.",
                // ========= Answers
                "Or, you could just carry on...",
                null,
                null,
                null,
                // ========= Keys
                "I am so frustrated, I'm vibrating.",
                null,
                null,
                null));

        line = "I am so frustrated, I'm vibrating.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "You make me want to scream!",
                null,
                null,
                null));

        line = "You make me want to scream!";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "I don't care any more! Go to hell!",
                null,
                null,
                null));

        line = "I don't care any more! Go to hell!";
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

        line = "Okay. Damn.";
        stages.Add(line,
            new Stage(1, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "So, it has nothing to do with me?",
                null,
                null,
                null));

        // *************************************************************** ACT 4

        line = "So, it has nothing to do with me?";
        stages.Add(line,
            new Stage(1, line, "I'm sorry you had to think that.",
                // ========= Answers
                "Yeah. Don't worry.",
                null,
                null,
                null,
                // ========= Keys
                "I still liked you.",
                null,
                null,
                null));

        line = "I still liked you.";
        stages.Add(line,
            new Stage(1, line, "I'm glad.",
                // ========= Answers
                "I still like you too.",
                null,
                null,
                null,
                // ========= Keys
                "...",
                null,
                null,
                null));

        line = "...";
        stages.Add(line,
            new Stage(0, line, "I missed you for a long time afterwards.",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "I don't know. This is weird.",
                null,
                null,
                null));

        line = "I don't know. This is weird.";
        stages.Add(line,
            new Stage(0, line, "Awkward.",
                // ========= Answers
                "I'm sorry.",
                null,
                null,
                null,
                // ========= Keys
                "I am the sorry one.",
                null,
                null,
                null));

        line = "I am the sorry one.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "It seemed like you're doing well.",
                null,
                null,
                null));

        line = "It seemed like you're doing well.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "I'm glad.",
                null,
                null,
                null));

        line = "I'm glad.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "...I think I should go now.",
                null,
                null,
                null));

        line = "...I think I should go now.";
        stages.Add(line,
            new Stage(0, line, "",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "Take care. And see you around.",
                null,
                null,
                null));

        line = "Take care. And see you around.";
        stages.Add(line,
            new Stage(0, line, "You too.",
                // ========= Answers
                null,
                null,
                null,
                null,
                // ========= Keys
                "",
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
