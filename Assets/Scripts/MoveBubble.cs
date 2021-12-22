using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;
    private Vector2 velocity;
    private bool coll = false;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0.5f, -1f);
        rb.velocity = velocity * speed;
    }

    private void FixedUpdate()
    {
        if(!coll)
        {
            velocity = rb.velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        coll = true;
        Vector2 reflect = Vector2.Reflect(velocity, collision.contacts[0].normal);
        rb.velocity = reflect;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        coll = false;
    }
}
