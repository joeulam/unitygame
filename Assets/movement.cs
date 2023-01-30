using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 5f;

    private Rigidbody2D rigidbody2d;
    private bool isGrounded = false;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, 0);
        rigidbody2d.velocity = direction * speed;

        if (isGrounded && Input.GetKeyDown("w"))
        {
            rigidbody2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
        Debug.Log("onfloor");
    }
}