using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCode : MonoBehaviour
{
    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groundMask;
    public PhysicsMaterial2D bounceMat, normalMat;
    public bool canJump = true;
    public float jumpValue = 0.0f;
    public GameObject rayPos;

    public Animator am;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        am = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (jumpValue == 0.0f && isGrounded)
        {
            rb.linearVelocity = new Vector2(moveInput * walkSpeed, rb.linearVelocity.y);
            am.SetBool("jump", false);
           
        }

        isGrounded = Physics2D.OverlapBox(rayPos.transform.position, Vector2.down,5f, groundMask);
        Debug.DrawRay(rayPos.transform.position, Vector2.down, Color.green, groundMask);

        if (jumpValue > 0)
        {
            rb.sharedMaterial = bounceMat;
        }else
        {
            rb.sharedMaterial = bounceMat;
        }

        if(Input.GetKey("space") && isGrounded && canJump)
        {
            jumpValue += 0.1f;
            am.SetBool("jump", true);

        }

        if (Input.GetKey("space") && isGrounded && canJump)
        {
            rb.linearVelocity = new Vector2(0.0f, rb.linearVelocity.y * Time.deltaTime);
            am.SetBool("fall", true);
        } 

        if(jumpValue >=20f && isGrounded)
        {
            float tempx = moveInput * walkSpeed;
            float tempy = jumpValue;
            rb.linearVelocity = new Vector2(tempx, tempy);
            ResetJump();
        }

        if(Input.GetKeyUp("space"))
        {
            if(isGrounded)
            {
                rb.linearVelocity = new Vector2(moveInput * walkSpeed, jumpValue);
                ResetJump();
            }
            canJump = true;
        }
         
        
    }

    void ResetJump()
    {
        canJump = false;
        jumpValue = 0;
    }
     
    

}
