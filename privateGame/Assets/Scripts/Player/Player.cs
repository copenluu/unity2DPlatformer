using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    #region variables

    [SerializeField] private Transform groundCheckTransform = null; //Declares to inspector so user can link to another object
    [SerializeField] private float moveSpeed = 1; //Declares moveSpeed float to inspector so user can change at will
    [SerializeField] private LayerMask groundLayer; //Declares groundLayer to inspector so user can choose layer for LayerMask
    [SerializeField] private LayerMask spikeLayer; //Declares spikeLayer to inspector so user can choose layer for LayerMask
    [SerializeField] private float jumpForce = 1; //Declares jumpForce float to inspector so user can change at will
    [SerializeField] private AudioClip damage; //Declares damage to inpsector with AudioClip
    [SerializeField] private float dashSpeed; // ^^
    


    public Animator animator;
    public Vector2 lastPositionOnTheGround;


    Hearts findHearts; //Calls Hearts script and sets name to findHearts within Spike script
    new Rigidbody2D rigidbody; //Shortcut for Rigidbody2D
    private float xInput; //Declares variable xInput as float
    private bool isGrounded; //Declares variable isGrounded as boolean
    private bool canDoubleJump; //Declares variable canDoubleJump as boolean
    private bool isGroundedSpike; //Declares variable isGroundedSpike as boolean
    private bool canDoubleJumpTwo; //Declares variable canDoubleJump as boolean
    private bool invincible = false; //Declares new boolean variable invincible
    private bool isGroundedDiagonal;
    private AudioSource damageaudio;
    

    #endregion


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); //On startup rigidbody is set to be shortcut for "GetCompononent<Rigidbody2D>();"
        findHearts = GameObject.FindGameObjectWithTag("Player").GetComponent<Hearts>(); //On start, finds component hearts from the gameObject that has the "Player" tag
        damageaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Checks to see if the Space key has been pressed down
        {
            if (isGroundedSpike) //Checks if the user is touching the spike and if it is true, allows if function
            {
                JumpTwo(); // Jumps
                canDoubleJumpTwo = true; //Sets canDoubleJump to true
            }
            else if (canDoubleJumpTwo) //Checks if canDoubleJump is true
            {
                JumpTwo(); //Jumps
                canDoubleJumpTwo = false; //Sets canDoubleJump to false, closing if function
            }

            if (isGrounded || isGroundedDiagonal) //Checks if the user is touching the ground and if it is true, allows if function
            {
                Jump(); // Jumps
                canDoubleJump = true; //Sets canDoubleJump to true
            }
            else if (canDoubleJump) //Checks if canDoubleJump is true
            {
                Jump(); //Jumps
                canDoubleJump = false; //Sets canDoubleJump to false, closing if function
            }
        } //JumpScript
        xInput = Input.GetAxis("Horizontal"); //Gets the input for the x axis from the user 

       


        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        PlayerDied();

        
        if (isGrounded)
        {
            lastPositionOnTheGround = gameObject.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            findHearts.numOfHearts = 10000;
            findHearts.health = 10000;
        }


    }
            
    private void FixedUpdate()
    {
       
        rigidbody.velocity = new Vector2(xInput * moveSpeed, rigidbody.velocity.y); //Allows the user to move, uses xInput multiplied by public "moveSpeed" and sets the gravity to be whatever the y axis is by default
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 5.7f;
        } //Sprint
        else
        {
            moveSpeed = 5f;
        }
        
       
        isGrounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundLayer); //Checks if linked gameObject "groundCheckTransform" is in contact with the "groundLayer" and sets isGrounded based on that
        isGroundedSpike = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, spikeLayer); //Checks if linked gameObject "groundCheckTransform" is in contact with the "groundLayer" and sets isGrounded based on that

        

    }

    private void Jump()
    {    
        rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //Sets player to jump on the factor of jumpForce
    }
    private void JumpTwo()
    {
        rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //Sets player to jump on the factor of jumpForce
    }
    private void DoubleJump()
    {
        rigidbody.AddForce((Vector2.up * jumpForce)/2, ForceMode2D.Impulse); //Sets player to double jump at half of original jump
    }

    
    private void OnTriggerStay2D(Collider2D other) //On collision with anything else
    {
        if (!invincible) //Checks if "invincible is not true
        {
            if (other.transform.CompareTag("spike")) //Checks if the collision is with the gameObject with "Player" tag
            {
                Damage();
            }

            if (other.transform.CompareTag("bunny")) //Checks if player collides with "Bunny" tag
            {
                Damage();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {    
        if (!invincible)
        {
            if (other.transform.CompareTag("bunny")) //Checks if player collides with "Bunny" tag
            {
                Damage();
            }
        }
       
    }

    public void Damage() //Damage method
    {
        findHearts.health--; //Decreases health by one
        damageaudio.PlayOneShot(damage); //Plays Hit audio
        StartCoroutine(Invulnerability()); //Begins Invulnerability coroutine
        rigidbody.velocity = new Vector2(0, 10);
    }



    public IEnumerator Invulnerability() //Runs coroutine Invulnerability
    {
        invincible = true; //Sets invincible to true
        yield return new WaitForSecondsRealtime(2f); //Uses yield to wait for seconds to wait the previously declared time from inspector
        invincible = false; //Once finished waiting, sets invincible to false
    }




    private void PlayerDied() //Sets method PlayerDied
    {
        if (findHearts.health == 0) //If health == 0
        {
            LevelManager.instance.GameOver(); //Calls script LevelManager and uses instance to run script "GameOver();"
            gameObject.SetActive(false); //Deactivates Player gameObject
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Diagonal"))
        {
            isGroundedDiagonal = true;
        }

        if (other.transform.CompareTag("reset"))
        {
            gameObject.transform.position = lastPositionOnTheGround;
            findHearts.health--;
            damageaudio.PlayOneShot(damage);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.CompareTag("Diagonal"))
        {
            isGroundedDiagonal = false;
        }
    }








}
