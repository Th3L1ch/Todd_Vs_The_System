using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PO {

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    public bool canDJ;

    void Start()
    {

    }

    private SpriteRenderer spriteRenderer;
    //private Animator animator;

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

        if (Input.GetButtonDown("Jump"))
        {
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

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
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