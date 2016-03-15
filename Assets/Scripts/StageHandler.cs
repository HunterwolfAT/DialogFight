using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class StageHandler {

	private static Dialouge dialouge;
	private static TextObjectHandle objecthandler = new TextObjectHandle();
    private static TextMesh introtext;

	public static Stage currentStage = null;
    public static bool end = false, win = false;

	public static void Init(TextMesh itext, AudioSource audiosource, AudioClip phonevoice, AudioClip voice) {
		dialouge = new Dialouge ();
		currentStage = dialouge.stages ["Take care. And see you around."];

		objecthandler.Init (audiosource, phonevoice, voice);
		UpdateText ();
        introtext = itext;
        end = false;
	}
	
	// Update is called once per frame
	public static void Update () {
		objecthandler.Update ();
	}

	public static void NextStage(int selectedOption) {
		switch (selectedOption) {
		case 1:
			if (currentStage.key1 != null) {
				currentStage = dialouge.stages [currentStage.key1];
                CheckFailState();
				UpdateText ();
			}
			break;
		case 2:
			if (currentStage.key2 != null) {
				currentStage = dialouge.stages [currentStage.key2];
                CheckFailState();
                UpdateText ();
			}
			break;
		case 3:
			if (currentStage.key3 != null) {
				currentStage = dialouge.stages [currentStage.key3];
                CheckFailState();
                UpdateText ();
			}
			break;
		case 4:
			if (currentStage.key4 != null) {
				currentStage = dialouge.stages [currentStage.key4];
                CheckFailState();
                UpdateText ();
			}
			break;
		}

		if (currentStage.newGamestate >= 0) {
			BulletHell.gamestate = currentStage.newGamestate;
		}

        // And explode all remaining bombs
        GameObject[] bombs = GameObject.FindGameObjectsWithTag("Bomb");
        foreach (GameObject bomb in bombs)
        {
            BombBehaviour bh = bomb.GetComponent<BombBehaviour>() as BombBehaviour;
            bh.Explode();
        }
    }

    public static void TryAdvance() // If no options are at the current stage, advance at button press!
    {
        if (currentStage.op1 == null) // No options
        {
            NextStage(1);
        }
    }

	private static void UpdateText() {
		objecthandler.UpdateText (currentStage.question, currentStage.op1, currentStage.op2, currentStage.op3, currentStage.op4, currentStage.innervoice);
	}

    private static void CheckFailState()
    {
        if (currentStage.question == "The call has ended.")
        {
            Debug.Log("THE END.");
            introtext.text = "That could have gone better... (Retry)";
            objecthandler.ending();
            end = true;
        }
        else if (currentStage.question == "")
        {
            Debug.Log("YOU WIN! THE END!");
            introtext.text = "Thank you for playing!\n\nDialog_Fight\nby Maximilian Siess, 2016\n\nFirst game for #1gam";
            objecthandler.ending();
            end = true;
            win = true;
        }
    }
}