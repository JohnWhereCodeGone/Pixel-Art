using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Animator _anim;
    public bool isMoving = false;

    void Start()
    {
        //Call the Rigidbody
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
         //Sets the movement direction
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //Sets movement speed
        Vector2 movement = new Vector2(moveX, moveY);
        movement.Normalize();
        movement *= moveSpeed;

        //Applies movement to the rigidbody
        rb.velocity = movement;
        _anim.SetFloat("movingY", moveY);
        _anim.SetFloat("movingX", moveX);

        if (moveX != 0 || moveY != 0)
        {
            _anim.SetBool("isMoving", true);
        }
        else if (moveX == 0 || moveY == 0)
        {
            _anim.SetBool("isMoving", false);
            
        }
    }



}
