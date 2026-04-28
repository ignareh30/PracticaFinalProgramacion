using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControler : MonoBehaviour
{
    public float speed = 3f;
   
    private Rigidbody2D playerRb;
    private Vector2 moveInput;

    public Player_Combat player_Combat;

    private void LateUpdate()
    {
        if (Input.GetButtonDown("Slash"))
        {
            player_Combat.Attack();
        }
        else if (Input.GetButtonUp("Slash"))
        {
            player_Combat.FinishingAttacking();
        }

    }

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
    }

   

}