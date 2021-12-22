using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D rb;
    private float horizontalMove = 0f;
    private Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        position.x += horizontalMove;
        rb.MovePosition(position);
    }

}
