using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speedCharacter;
    [SerializeField] private float jumpCharacter;
    private bool isJumpingRight;
    private Vector3 moveVector;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        GetInput();
       JumpLogicCharacter();
    }
   private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speedCharacter * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speedCharacter * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speedCharacter * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speedCharacter * Time.deltaTime;
        }

    }
    private void JumpLogicCharacter()
    {
        if(Input.GetAxis("Jump") > 0)
        {
            if(isJumpingRight)
            {
                rb.AddForce(transform.up * jumpCharacter);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpdate(collision, true);
        
    }
    private void OnCollisionExit(Collision collision)
    {
        IsGroundedUpdate(collision, false);
    }
    private void IsGroundedUpdate(Collision collision,bool value)
    {
        if(collision.gameObject.tag == ("Ground"))
        {
            isJumpingRight = value;
        }
    }
}
