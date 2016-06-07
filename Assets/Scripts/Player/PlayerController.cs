using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //Floats for the speed, in-Air additonal speed, JumpVelocity and time invincibilty after getting hit
    public float speed = 10, inAirSpeed = 8, JumpVelocity = 20, invincibleTimeAfterHurt = 3;

    //The layers the player will see as ground
    public LayerMask playerMask;

    //A bool the determins if the player can control the player sprite in the air
    public bool canMoveInAir = true;

    //A float that saves the velocity of the player
    private float savedVelocity = 0f;

    //The bools used for ground detection
    bool isGrounded = false, isOnLeft = false, isOnRight = false, playerIsInAir = true;

    //The AudioClip that will be the sound the player makes when it gets hurt
    public AudioClip hurtClip;

    //Transforms used to ground detection
    Transform myTrans, tagGround, tagLeft, tagRight;

    //The rigidbody of the players object
    Rigidbody2D rb;

    //The particleSystem on the player
    GameObject particleSys;

    //All the players colliders
    Collider2D[] myColls;

    //The AudioSource that the player has
    AudioSource src;

    //The animator the player uses, on the player sprite
    Animator ani;

    void Start()
    {
        //Getting all the diffrent componets of the player
        myColls = gameObject.GetComponents<Collider2D>();
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();
        src = GetComponentInChildren<AudioSource>();

        //Searching for the ground detection tags.
        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
    }

    void FixedUpdate()
    {
        //Checking if ground detection is true
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);

		float h = Input.GetAxis ("Horizontal");

        Move(Input.GetAxis("Horizontal"));
        
        //If none of the ground detection is hitting the ground the player is in the air
        if (!isGrounded)
        {
            playerIsInAir = true;
            //ani.SetBool("isOnGround", false);
        }
        else
        {
            playerIsInAir = false;
            //ani.SetBool("isOnGround", true);
        }

        //Move function sending the contoller input as a float
        Move(Input.GetAxis("Horizontal"));

        //ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            //ani.SetBool("isOnGround", false);
        }
    }

    void Move(float horizontalInput)
    {
        /*if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(3, transform.localScale.y, transform.localScale.z);
        }
        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);
        }*/

        if (!canMoveInAir && playerIsInAir)
        {
            Vector2 airVelocity = rb.velocity;
            airVelocity.x = savedVelocity + (Input.GetAxis("Horizontal") * inAirSpeed);
            rb.velocity = airVelocity;
            return;
        }

        Vector2 moveVel = rb.velocity;
        moveVel.x = horizontalInput * speed;
        rb.velocity = moveVel;

        if (transform.Find("Particle System") != null)
        {
            if (moveVel.x >= 1 || moveVel.x <= -1)
            {
                transform.Find("Particle System").gameObject.SetActive(true);
            }
            else
            {
                transform.Find("Particle System").gameObject.SetActive(false);
            }
        }
    }

    public void Jump()
    {

        if (isGrounded || isOnLeft || isOnRight)
        {
            rb.velocity += JumpVelocity * Vector2.up;
            savedVelocity = Input.GetAxis("Horizontal") * speed;
        }
        //transform.Find("Particle System").gameObject.SetActive(false);
    }

}