using UnityEngine;
using System.Collections;

public class SelfDisappear : MonoBehaviour {

    private SpriteRenderer sprite;
    private float timer;
    public float timer_threshold = 1f;

    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += 100f * Time.deltaTime;
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1f - (timer / (timer_threshold * 100f)));
        transform.localScale *= 1.009f;

        if ((timer / (timer_threshold * 100f)) > 1f) // Done
        {
            Debug.Log("And... Gone!");
            Destroy(this.gameObject);
        }
    }
}
