using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public ScoreScript score;
    public float speed;
    private float horizontalScreenLimit;
    private float verticalScreenLimit;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        horizontalScreenLimit = 13.5f;
        verticalScreenLimit = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        // Debug.Log((Input.GetAxis("Vertical").ToString()));
    }

    void Movement() 
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * speed);
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector2(transform.position.x * -1f, transform.position.y);
        }
       if (transform.position.y > verticalScreenLimit || transform.position.y <= -verticalScreenLimit)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y * -1f);
        }
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        score.score++;
        Destroy(trigger.gameObject);
    }
    
}
