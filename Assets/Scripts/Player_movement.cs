using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Animator animator;
    public Joystick joystick;
    public Rigidbody2D rb;

    public float moveSpeed = 5f;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //input
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed *  Time.fixedDeltaTime);
    }
}
