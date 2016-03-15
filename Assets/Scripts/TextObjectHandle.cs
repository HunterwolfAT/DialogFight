using UnityEngine;
using System.Collections;

public class TextObjectHandle {

	private GameObject question, option1, option2, option3, option4, innervoice;
	private BoxCollider2D bo1, bo2, bo3, bo4;
	public TextMesh q, o1, o2, o3, o4, iv;
	private string fullq, fullo1, fullo2, fullo3, fullo4, fulliv; // The full strings (given)
	private int counter;
	private bool doneq, done1, done2, done3, done4, doneiv = true;
	public float timer = 0f, threshold = .1f, speed = 3f;
    private AudioSource audiosource;
    public AudioClip phonevoice, voice;

	// Use this for initialization
	public void Init (AudioSource Source, AudioClip PhoneVoice, AudioClip Voice) {
		question = GameObject.Find ("Partner_Speech");
		option1 = GameObject.Find ("Option1");
		option2 = GameObject.Find ("Option2");
		option3 = GameObject.Find ("Option3");
		option4 = GameObject.Find ("Option4");
		innervoice = GameObject.Find ("InnerVoice");
		q = question.GetComponent <TextMesh>();
		o1 = option1.GetComponent <TextMesh>();
		o2 = option2.GetComponent <TextMesh>();
		o3 = option3.GetComponent <TextMesh>();
		o4 = option4.GetComponent <TextMesh>();
		iv = innervoice.GetComponent <TextMesh>();
		bo1 = option1.GetComponent<BoxCollider2D>();
		bo2 = option2.GetComponent<BoxCollider2D>();
		bo3 = option3.GetComponent<BoxCollider2D>();
		bo4 = option4.GetComponent<BoxCollider2D>();
        audiosource = Source;
        phonevoice = PhoneVoice;
        voice = Voice;
	}

	// Give new text to draw
	public void UpdateText(string fq, string fo1, string fo2, string fo3, string fo4, string fiv, float newthreshold = .1f) {
		fullq = fq;
		fulliv = fullo1 = fullo2 = fullo3 = fullo4 = null;
		if (fo1 != null)
			fullo1 = "* " + fo1;
		if (fo2 != null)
			fullo2 = "* " + fo2;
		if (fo3 != null)	
			fullo3 = "* " + fo3;
		if (fo4 != null)	
			fullo4 = "* " + fo4;
		if (fiv != null)
        {
            if (fiv != "")
            {
                fulliv = "(" + fiv + ")";
            }
        }
			
		threshold = newthreshold;
		counter = 0;
		timer = 0f;
		doneq = done1 = done2 = done3 = done4 = doneiv = false;
		o1.text = "";
		o2.text = "";
		o3.text = "";
		o4.text = "";
		iv.text = "";
        updateBox(bo1, o1);
        updateBox(bo2, o2);
        updateBox(bo3, o3);
        updateBox(bo4, o4);

        if (fq == "The call has ended.")
        {
            q.fontStyle = FontStyle.Normal;
        }

        if (fo1 == null)
        {
            fulliv = "Press to Advance";
        }

        Debug.Log ("Text updated! New q is " + fullq);
	}

	// Update is called once per frame
	public void Update () {
		if (timer >= threshold) {
			if (!doneq) {
				if (counter > fullq.Length) {
					doneq = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(phonevoice);
					q.text = fullq.Substring (0, counter);
				}
			} else if (!done1) {
				if (fullo1 == null || counter > fullo1.Length) {
					done1 = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(voice, 0.8f);
                    o1.text = fullo1.Substring (0, counter);
					updateBox(bo1, o1); // Refit collider to new size
				}
			} else if (!done2) {
				if (fullo2 == null || counter > fullo2.Length) {
					done2 = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(voice, 0.8f);
                    o2.text = fullo2.Substring (0, counter);
					updateBox(bo2, o2); // Refit collider to new size
				}
			} else if (!done3) {
				if (fullo3 == null || counter > fullo3.Length) {
					done3 = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(voice, 0.8f);
                    o3.text = fullo3.Substring (0, counter);
					updateBox(bo3, o3); // Refit collider to new size
				}
			} else if (!done4) {
				if (fullo4 == null || counter > fullo4.Length) {
					done4 = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(voice, 0.8f);
                    o4.text = fullo4.Substring (0, counter);
					updateBox(bo4, o4); // Refit collider to new size
				}
			} else if (!doneiv) {
				if (fulliv == null || counter > fulliv.Length) {
					doneiv = true;
					counter = 0;
				} else {
                    audiosource.PlayOneShot(voice, 0.5f);
                    iv.text = fulliv.Substring (0, counter);
				}
			}
			counter++;
			timer = 0f;
		}
		timer += speed * Time.deltaTime;
		//Debug.Log ("Update! " + timer);
	}

	private void updateBox( BoxCollider2D box , TextMesh tm ) {
		box.size = new Vector2(getWidth(tm), box.size.y);
		box.offset = new Vector2 (box.size.x / 2f, box.offset.y);
	}

	public static float getWidth(TextMesh mesh) {
		float width = 0;

		foreach (char symbol in mesh.text) {
			CharacterInfo info;
			if (mesh.font.GetCharacterInfo(symbol, out info, mesh.fontSize, mesh.fontStyle)) {
				width += info.advance;
			}
		}
		return width * mesh.characterSize * 0.1f;
	}

    public void ending()
    {
        q.text = "";
        o1.text = "";
        o2.text = "";
        o3.text = "";
        o4.text = "";
        iv.text = "";
    }
}