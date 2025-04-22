using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMovement movement;
    private PlayerAnimation playerAnimation;
    private PlayerSpriteFlip spriteFlip;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
        playerAnimation = GetComponent<PlayerAnimation>();
        spriteFlip = GetComponent<PlayerSpriteFlip>();
    }

    private void Update()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement.SetMovementInput(mx, my);
        playerAnimation.UpdateRunningAnimation(mx, my);
        spriteFlip.FlipSprite(mx);
    }
}