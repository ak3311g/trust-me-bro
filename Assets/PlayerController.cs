using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        if(IsGrounded())
        {playerRb.velocity = new Vector2(moveInput * moveSpeed, playerRb.velocity.y);}

        if(transform.position.y < -15f)
        {
            // Reset the player's position if they fall off the screen
            transform.position = new Vector2(0f, 0f);
            playerRb.velocity = Vector2.zero;
        }
    }

    /* private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            playerRb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    } */

    private bool IsGrounded()
    {
        // Check if the player is touching the ground
        return Physics2D.Raycast(transform.position, Vector2.down, 1f, groundLayer);
    }
}
