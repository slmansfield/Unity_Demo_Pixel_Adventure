using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private float dirX = 0f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private float moveSpeed = 7f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))

        {
            rb.velocity = new Vector3(0, jumpForce, 0);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        // if you are moving to the right
        if (dirX > 0f)
        {
            anim.SetBool("Running", true);
            sprite.flipX = false;
        }
        // if you are moving to the left
        else if (dirX < 0f)
        {
            anim.SetBool("Running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}
