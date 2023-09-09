using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inGame;
    public Transform paddle;
    public float speed;
    public TextManager textmanager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (textmanager.gameOver)
        {
            return;
        }
        if (!inGame)
        {
            transform.position = paddle.position;
        }

        if (Input.GetButtonDown ("Horizontal") && !inGame)
        {
            inGame = true;
            rb.AddForce (Vector2.up * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Bottom"))
        {
            rb.velocity = Vector2.zero;
            inGame = false;
            textmanager.UpdateLives (-1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag ("Brick"))
        {
            textmanager.UpdateScore (other.gameObject.GetComponent<Bricks>().scores);
            textmanager.UpdateBricksTotal();
            Destroy (other.gameObject);
        }
    }
}
