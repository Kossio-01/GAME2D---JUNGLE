using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D _Rigidbody2D;
    float horizontal;
    public float speed = 5f;
    public float jumpForce = 10f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    private bool isGrounded;
    private void Start()
    {
        _Rigidbody2D  = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

 
// C#
void Update()
{
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    horizontal = Input.GetAxisRaw("Horizontal");

    animator.SetFloat("Speed", Mathf.Abs(horizontal));
    animator.SetBool("isGrounded", isGrounded);

    if (Input.GetButtonDown("Jump") && isGrounded)
    {
        _Rigidbody2D.linearVelocity = new Vector2(_Rigidbody2D.linearVelocity.x, jumpForce);
    }
}

    private void FixedUpdate()
    {
        _Rigidbody2D.linearVelocity = new Vector2 (horizontal * speed, _Rigidbody2D.linearVelocity.y);
    }
}
