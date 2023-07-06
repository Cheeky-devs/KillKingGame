using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    private Rigidbody rb;
    public LayerMask layermask;
    public bool grounded;
    public bool crouch;
    public bool holdGun;
    public bool shoot;

    public FixedJoystick joystick;


    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Grounded();
        Jump();
        Move();
       StartCrouching();
       StopCrouching();
        HoldGun();
        NoHoldGun();
        


    }


    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }
     
    }

    private void Grounded()
    {
        if (Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layermask))
        {
            this.grounded = true;
        }
        else
        {
            this.grounded = false;
        }
        this.anim.SetBool("jump", !this.grounded);
        
    }

    private void Move()
    {
        float verticalAxis = joystick.Vertical;
        float horizontalAxis = joystick.Horizontal;

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
        movement.Normalize();

        this.transform.position += movement * 0.1f;

        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);
    }
    

     private void StartCrouching()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.anim.SetBool("crouch", !this.crouch);
        }
    }

    private void StopCrouching()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            
            this.anim.SetBool("crouch", this.crouch);
        }
    }

    private void HoldGun()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.anim.SetBool("holdGun", !this.holdGun);

        }
    }
    private void NoHoldGun()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            this.anim.SetBool("holdGun", this.holdGun);

        }
    }
  

}
