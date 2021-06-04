// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] public bool isMoving = true;
    [SerializeField] Rigidbody2D myRigidBody;

    private Vector2 moveDirection;
    private SpriteRenderer mySpriteRenderer;

    private void Update()
    {
        if (isMoving)
        {
            CheckMovement();
            ProcessInputs();
        }
    }

    private void FixedUpdate()
    {
        playerMovement();
    }

    private void CheckMovement()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            GetComponent<Animator>().SetBool("Left", true);
        }
        else
        { GetComponent<Animator>().SetBool("Left", false); }


        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            GetComponent<Animator>().SetBool("Right", true);
        }
        else
        { GetComponent<Animator>().SetBool("Right", false); }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            GetComponent<Animator>().SetBool("Down", true);
        }
        else
        { GetComponent<Animator>().SetBool("Down", false); }


        if (Input.GetAxisRaw("Vertical") > 0)
        {
            GetComponent<Animator>().SetBool("Up", true);
        }
        else
        { GetComponent<Animator>().SetBool("Up", false); }
    }

    private void ProcessInputs()
    {
        if (!isMoving)
        {
            return;
        }

        float moveX = Input.GetAxisRaw("Horizontal");

        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }

    private void playerMovement()
    {
        if (!isMoving)
        {
            return;
        }

        myRigidBody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
