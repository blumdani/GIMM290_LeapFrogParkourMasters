using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 100.0f; // Adjust to desired turn speed
    public float jumpForce = 2.0f;
    private bool isJumping = false;

    void Update()
    {
        float move = 0;
        float turn = 0;

        Rigidbody rb = GetComponent<Rigidbody>();

        if (gameObject.name == "Player2")
        {
            if(!HitDetector.canJump) 
            {
                transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
            }
            else{
                if (Input.GetKey(KeyCode.I)) move = 1;
                if (Input.GetKey(KeyCode.J)) turn = -1;
                if (Input.GetKey(KeyCode.L)) turn = 1;
                if (Input.GetKeyDown(KeyCode.K) && !isJumping) 
                {
                    rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                    isJumping = true;
                }
            }
        }
        else if (gameObject.name == "Player1")
        {
            if(!HitDetector.canJump) {
                transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
            }
            else {
                if (Input.GetKey(KeyCode.W)) move = 1;
                if (Input.GetKey(KeyCode.A)) turn = -1;
                if (Input.GetKey(KeyCode.D)) turn = 1;
                if (Input.GetKeyDown(KeyCode.S) && !isJumping) 
                {
                    rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                    isJumping = true;
                }
            }
        }

        // Rotate the character
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);

        // Move the character in the direction it is facing
        if (move != 0)
        {
            Vector3 movement = transform.forward * move * speed;
            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
        }
        else
        {
            // If no movement key is being pressed, stop the character from moving
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}