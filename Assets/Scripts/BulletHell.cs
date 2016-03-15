using UnityEngine;
using System.Collections;

public class BulletHell : MonoBehaviour {

	public static int gamestate = 0, oldgamestate = 0; // Do Nothing at first
    public Rigidbody2D bullet;
    public Rigidbody2D bomb;
    public float speedboost = 5f;
	private float timer = 0f, timer2 = 0f, timer3 = 0f, angleTimer = 0f;
	private GameObject spawn;

	// Use this for initialization
	void Start () {
		spawn = GameObject.Find("Spawner");
	}

	// Update is called once per frame
	void Update () {

        // If gamestate changed, reset timers!
        if (gamestate != oldgamestate)
        {
            timer = timer2 = timer3 = 0f;
        }

        oldgamestate = gamestate;

		switch (gamestate) {
		case 0:
			// Do nothing
			break;
		case 1:     // Basic, Tutorial Bullet Spray
			if (timer > 0.2f)
                {
                    newBullet();
				    timer = 0f;
			    }   
			break;
       case 2: // Medium Bullet Spray
            if (timer > 0.1f)
                {
                    newBullet();
                    timer = 0f;
                }     
            break;
       case 3: // Medium Bullet Spray with Low Bombs (Tutorial)
            // The BULLET part
            if (timer > 0.1f)
                {
                    newBullet();
                    timer = 0f;
                }     
            // BOMBS Part
            if (timer2 > 6f)
                {
                    newBomb(8f);
                    timer2 = 0f;
                }
            break;
      case 4: // Heavy Bullet Spry
            if (timer > 0.05f)
                {
                    newBullet();
                    timer = 0f;
                }
            if (timer2 > 0.2f)
                {
                    newBullet(1);
                    timer2 = 0f;
                }
            break;
        case 5: // Medium Bullet Spray with Fast Bombs (Normal)
                // The BULLET part
            if (timer > 0.1f)
            {
                newBullet();
                timer = 0f;
            }
            // BOMBS Part
            if (timer2 > 6f)
            {
                newBomb(4f);
                timer2 = 0f;
            }
            break;
            case 6: // Heavy Bullet Spray with (slow) Bombs
            if (timer > 0.05f)
            {
                newBullet();
                timer = 0f;
            }
            if (timer2 > 0.2f)
            {
                newBullet(1);
                timer2 = 0f;
            }
            // BOMBS Part
            if (timer2 > 6f)
            {
                newBomb(8f);
                timer2 = 0f;
            }   
            break;
            default:
			Debug.Log ("Gamestate " + gamestate + " is not defined!");
			break;
		}

        timer += 1f * Time.deltaTime;
        timer2 += 1f * Time.deltaTime;
        timer3 += 1f * Time.deltaTime;
    }

    private void newBullet(int offset = 0)
    {
        Quaternion newrotation = spawn.transform.rotation * Quaternion.Euler(0, 0, -75 + (-1000f / (offset+1)) * angleTimer);

        if (-75 + (-1000f / (offset+1)) * angleTimer < -160)
        {   // Limit the bullets to sensible range
            angleTimer = 0f;
        }
        angleTimer += Time.deltaTime;

        Instantiate(bullet, spawn.transform.position, newrotation);
    }

    private void newBomb(float bombFuse)
    {
        Rigidbody2D newbomb = (Rigidbody2D)Instantiate(bomb, spawn.transform.position, Quaternion.identity);
        //ConstantForce2D newforce = newbomb.GetComponent<ConstantForce2D>();
        //newforce.relativeForce = new Vector2(5f + Random.value * 5f, -5f + 5f * -Random.value);
        Debug.Log(Random.value + ", " + Random.value);
        newbomb.velocity = new Vector2(5f * Random.value, -2f - 1f * -Random.value);
        BombBehaviour bombb = newbomb.GetComponent<BombBehaviour>();
        bombb.timer_threshold = bombFuse;
    }
}