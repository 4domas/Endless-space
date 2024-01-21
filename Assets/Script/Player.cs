using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f; // Adjust the speed as needed
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0f, moveInput);
        rb.velocity = movement * playerSpeed;
    }
}