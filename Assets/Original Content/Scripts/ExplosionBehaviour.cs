using UnityEngine;
using System.Collections;

public class ExplosionBehaviour : MonoBehaviour {

    private SpriteRenderer sprite;
    private float timer, r_color;
    public float timer_threshold = 1f;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        r_color = sprite.color.r;
	}
	
	// Update is called once per frame
	void Update () {
        timer += 100f * Time.deltaTime;
        sprite.color = new Color((timer / (timer_threshold * 100f)) + r_color, (timer / (timer_threshold * 100f)), (timer / (timer_threshold * 100f)), 1f - (timer / (timer_threshold * 100f)));
        transform.localScale *= 1.009f;

        if ((timer / (timer_threshold * 100f)) > 1f)  // Explosion Gone
        {
            Destroy(this.gameObject);
        }
    }
}
