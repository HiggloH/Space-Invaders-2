using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed = 10;

    public Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * moveSpeed);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Vector2.right * moveSpeed);
        }
    }
}
