using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [HideInInspector]
    public bool mustPatrol;
    private bool mustFlip;

    public Rigidbody2D rb;
    public Transform groundCheckPosition;
    public LayerMask groundLayer;
    public LayerMask playerLayer;
    public LayerMask spikeLayer;
    public LayerMask bunnyLayer;
    public Collider2D bodyCollider;

    



    

    private void Start()
    {
        mustPatrol = true;
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }  
    }

    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustFlip = !Physics2D.OverlapCircle(groundCheckPosition.position, 0.1f, groundLayer);
        }
    }

    private void Patrol()
    {
        if (mustFlip || bodyCollider.IsTouchingLayers(groundLayer) || bodyCollider.IsTouchingLayers(playerLayer))
        {
            Flip();
        }

        rb.velocity = new Vector2(moveSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    private void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        moveSpeed *= -1;
        mustPatrol = true;
    }

    

}
