using UnityEngine;
using System.Collections;

public class BombBehaviour : MonoBehaviour {

    private SpriteRenderer sprite;
    private GameObject selectedOption;
    public SpriteRenderer explosion;
    public GameObject option_feedback;
    public AudioClip wrongOption;
    private AudioSource audiosource;
    private float timer;
    public float timer_threshold = 5f;

    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        audiosource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += 100f * Time.deltaTime;
        //Debug.Log((timer / (timer_threshold * 100f)));
        sprite.color = new Color(sprite.color.r, 1f - (timer / (timer_threshold * 100f)), sprite.color.b);

        if ((timer / (timer_threshold * 100f)) > 1f)  // BOOM!
        {
            // Select the line it is on
            EnterOption();
            //ExplodeAll();
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("OptionLine")) // Still just born!
        {
            CircleCollider2D circlecollider = gameObject.GetComponent<CircleCollider2D>();
            circlecollider.enabled = true;
        }
        /*
        if (coll.gameObject.tag == "Border" && timer > 0.5f) // Ignore border when you are just born
        { // Bouncing off the walls! You know, as bombs tend to do.
            if (transform.position.y < -0.5 || transform.position.y > 0.29) // bottom or top border
            {
                Vector3 localVelocity = body.transform.InverseTransformDirection(body.velocity);

                body.velocity = new Vector2(body.velocity.x, -body.velocity.y);
                force.relativeForce = new Vector2(force.force.x, -force.force.y);
            } else // left or right border
            {
                Vector3 localVelocity = body.transform.InverseTransformDirection(body.velocity);

                body.velocity = new Vector2(-body.velocity.x, body.velocity.y);
                force.relativeForce = new Vector2(-force.force.x, force.force.y);
            }
        }
        */
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (selectedOption == null && coll.gameObject.CompareTag("OptionLine"))
        {
            selectedOption = coll.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        selectedOption = null;
    }

    void EnterOption()
    {
        GameObject feedback = (GameObject) Instantiate(option_feedback, new Vector3(0f, 0.22f - ((selectedOption.layer - 8) * 0.29f), 0f), Quaternion.identity);
        audiosource.PlayOneShot(wrongOption, 1.3f); // Play Soundeffect
        SpriteRenderer feedback_renderer = feedback.GetComponent<SpriteRenderer>();
        feedback_renderer.color = new Color(0.8f, 0.0f, 0.0f, 0f); // Make it BOMB RED
        StageHandler.NextStage(selectedOption.layer - 7);	// Usable layers start at 8
    }

    /*
    void ExplodeAll() // Explode all bombs
    {
        GameObject[] bombs = GameObject.FindGameObjectsWithTag(this.gameObject.tag);
        foreach(GameObject bomb in bombs)
        {
            BombBehaviour bh = bomb.GetComponent<BombBehaviour>() as BombBehaviour;
            if (bh != null && bh != this)
                bh.Explode();
        }
        Explode();
    }*/

    public void Explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
