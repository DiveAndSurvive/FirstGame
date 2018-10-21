//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Movement : MonoBehaviour {
//    public float runSpeed;
//    public float jumpSpeed;
//    public float jumpVel;
//    public float jumpDecaySpeed;
//    public float gravity;

//    public Rigidbody2D rig;

//    Vector2 dir = new Vector2(0, 0);

//	// Use this for initialization
//	void Start () {

//	}

//	// Update is called once per frame
//	void Update () {
//        if(Input.GetKeyDown(KeyCode.Space))
//        {
//            rig.AddForce(transform.up * jumpSpeed);
//        }
//        if (jumpVel > 0)
//        {
//            jumpVel -= jumpDecaySpeed * jumpSpeed * Time.deltaTime;
//        }

//        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement instance;
    public float maxSpeed;
    public float jumpForce;
    public bool isGrounded;
    public bool isFacingRight = true;
    public bool canMoveWhileJumping;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float checkRadius = 0.2f;
    private Rigidbody2D rb2d;
    private Animator anim;

    void Start () {
        instance = this;
    }

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }
    //this function for physical stuff and calculation
    void FixedUpdate()
    {
        checkForGround();
        Move();
    }

    void Update()
    {
        //anim.SetBool("Grounded", isGrounded);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    //this function moves the player
    void Move()
    {
        //this if stat stop the player from moving while he's jumping
        if (!isGrounded && !canMoveWhileJumping)
            return;
        rb2d.transform.rotation = new Quaternion(0, 0, 0, 0);
        //here i used get axis to get a value between 0 and 1 when the player hit the right and left arrows
        float move = Input.GetAxis("Horizontal");
        //anim.SetFloat("Speed", Mathf.Abs(move));
        //here my players move by effecting his rigidbody compement velocity
        rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);
        if (move < 0 && isFacingRight)
            Flip();
        if (move > 0 && !isFacingRight)
            Flip();
    }
    //this function able my player to jump by adding force to his y axis
    void Jump()
    {
        rb2d.AddForce(new Vector2(0, jumpForce));
    }
    //this function check if there is a ground under my player so ican make sure he is grounded
    void checkForGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    //this function flips the player to other direction right to left
    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
