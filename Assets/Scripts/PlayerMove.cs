using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed = 1.3f;
	private bool intro = true;
	private int introstage = 1;
	private SpriteRenderer heart_spriterenderer;
	public SpriteRenderer phone_spriterenderer;
	public Animator phone_animator;
	public SpriteRenderer speech_spriterenderer;
    public SpriteRenderer option_feedback;
	public Sprite phone_call_sprite;
    public Sprite phone_end_sprite;
	public TextMesh introtextmesh;

	private Rigidbody2D body;
	//private StageHandler stagehandler;
	private GameObject selectedOption = null;
	private int horizontal, vertical = 0;
	private float introfade = 0f, fadespeed = 1f;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D>();
		heart_spriterenderer = GetComponent<SpriteRenderer>();
		StageHandler.Init (introtextmesh);
		//BulletHell.gamestate = 1;	//TODO: Testing only!
	}

	// Update is called once per frame
	void Update () {

		// MOVEMENT CONTROLS
		horizontal = (int)Input.GetAxisRaw("Horizontal");
		vertical = (int)Input.GetAxisRaw("Vertical");
		body.AddForce( new Vector2(horizontal * speed, vertical * speed) );
		//transform.Translate (horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);

		// OTHER CONTROLS
		if (Input.GetButtonUp("Submit")) {
			if (selectedOption != null) {
                if (selectedOption.CompareTag("Option") || selectedOption.CompareTag("Phone"))
                {
                    EnterOption();
                }
			} else
            {
                StageHandler.TryAdvance();
                
                // If the game has ended, restart it!
                if (StageHandler.end)
                {
                    StageHandler.Init(introtextmesh);
                    Application.LoadLevel(0);
                }
            }
		}
			
		if (intro) {
			PlayIntro ();
		} else {
			StageHandler.Update ();
		}

        if (StageHandler.end)
        {
            phone_spriterenderer.sprite = phone_end_sprite;
            if (speech_spriterenderer.color.a > 0f)
            {
                speech_spriterenderer.color = new Color(1f, 1f, 1f, introfade);
                introtextmesh.color = new Color(1f, 1f, 1f, 1f - introfade);
                introfade -= fadespeed * Time.deltaTime;
            }
        }
    }

	void OnTriggerStay2D(Collider2D coll) {
		if (!intro || coll.gameObject.tag != "Option") { // Options dont work in intro-mode
			if (selectedOption == null && !coll.gameObject.CompareTag("OptionLine")) {
				selectedOption = coll.gameObject;
				// Option to select
				if (selectedOption.CompareTag ("Option")) {
					TextMesh textmesh = selectedOption.GetComponent<TextMesh> ();
					textmesh.color = Color.yellow;
				}
			}
		}
		// Bounce-Bullet
		if (coll.gameObject.CompareTag ("Bullet")) {
			// Move the player
			transform.position = new Vector3 (transform.position.x + Random.Range(0.2f, 0.8f), transform.position.y - Random.Range(0.2f, 0.8f), 0);

			// Check if player is out of bounds
			if (transform.position.y < -0.6) {
				transform.position = new Vector3 (transform.position.x, -0.6f, 0f);
			}
			if (transform.position.x > 2.83) {
				transform.position = new Vector3 (2.83f, transform.position.y, 0f);
			}
		}
	}
		
	void OnTriggerExit2D(Collider2D coll) {
		if (selectedOption != null) {
			if (selectedOption.CompareTag ("Option")) {
				TextMesh textmesh = selectedOption.GetComponent<TextMesh> ();
				textmesh.color = Color.white;
			}
			selectedOption = null;
		}
	}

	private void EnterOption() {
        if (intro && selectedOption.tag == "Phone" && introstage == 4) { // Hit the phone in the intro
			phone_spriterenderer.sprite = phone_call_sprite;
			phone_animator.applyRootMotion = true;
			introstage++;
		} else { // Hit an Option!
            Debug.Log("Clang!");
            Instantiate(option_feedback, new Vector3(0f,0.22f - ((selectedOption.layer - 8) * 0.29f), 0f), Quaternion.identity);
			StageHandler.NextStage (selectedOption.layer - 7);	// Usable layes start at 8
		}
    }

	private void PlayIntro() {
		switch (introstage) {
		case 1:	//Fade the heart in
			if (introfade < 1f) {
				heart_spriterenderer.color = new Vector4 (1, 1, 1, introfade);
				introfade += fadespeed * Time.deltaTime;
			} else {
				introfade = 0f;
				introstage++;
			}
			break;
		case 2: // Fade the Phone in
			if (introfade < 1f) {
				phone_spriterenderer.color = new Vector4 (1, 1, 1, introfade);
				introfade += fadespeed * Time.deltaTime;
			} else {
				introfade = 0f;
				introstage++;
			}
			break;
		case 3: // Fade the intro text in
			if (introfade < 1f) {
				introtextmesh.color = new Vector4 (1, 1, 1, introfade);
				introfade += fadespeed * Time.deltaTime;
			} else {
				introfade = 0f;
				introstage++;
			}
			break;
		case 5: // No 4! 4 is waiting for the phone to be answered. Moves the Phone to the bottom left corner
			Vector3 target_phone_vector = new Vector3 (-2.981f, 0.635f, 0f);
			if (phone_spriterenderer.transform.position != target_phone_vector || introfade < 1f) {
				phone_spriterenderer.transform.position = Vector3.MoveTowards (phone_spriterenderer.transform.position, target_phone_vector, 2f * Time.deltaTime);
				introtextmesh.color = new Vector4 (1, 1, 1, 1 - introfade);
				introfade += fadespeed * Time.deltaTime;
			} else {
				introfade = 0f;
				introstage++;
			}
			break;
		case 6:
			if (introfade < 1f) {
				speech_spriterenderer.color = new Vector4 (1, 1, 1, introfade);
				introfade += fadespeed * Time.deltaTime;
			} else {
				// Intro DONE!
				intro = false;
			}
			break;
		}
	}
}