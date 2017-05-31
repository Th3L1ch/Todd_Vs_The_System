using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PO {

    public float maxSpeed = 15;
    public float jumpTakeOffSpeed = 15;
    public bool canDJ;
    static int score;

    //Set back to private non static when the gravity functions are moved back to this script from PO.cs
    //private SpriteRenderer spriteRenderer;
    public static SpriteRenderer spriteRenderer;

    //private Animator animator;

    void Start()
    {
        spriteRenderer.flipX = false;
    }

    // Use this for initialization
    void Awake()
    {
    spriteRenderer = GetComponent<SpriteRenderer>();
    // animator = GetComponent<Animator>();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        //Sprint function currently only for pc, maybe look into key binding in the future, if other platforms are considered.
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 25;
        }
        else
        {
            maxSpeed = 15;
        }

        if (Input.GetButtonDown("Jump"))
        {
            score++;
            if (grounded)
            {
                velocity.y = jumpTakeOffSpeed;
                canDJ = true;
            }
            else
            {
                if (canDJ)
                {
                    canDJ = false;
                    velocity.y = jumpTakeOffSpeed;
                }
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        if (move.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (move.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = spriteRenderer.flipX;
        }

        /*
        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        */
        targetVelocity = move * maxSpeed;
    }
}

//reset Level
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);﻿