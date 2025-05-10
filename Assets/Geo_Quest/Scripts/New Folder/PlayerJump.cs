using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;  // store the player's physics component
    public float jumpForce = 10;      // Forces

    public float PlayerHeight = 10f;
    public float PlayerRadius = 10f;

    //Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;

    //Forces 
    public float jump = 10;
    public float fallForce = 2;
    private Vector2 _gravityVector;
                                     
    // Start is called before the first frame update
    void Start()
    {
        _gravityVector = new Vector2(0, Physics.gravity.y);
       _rigidbody2D = GetComponent<Rigidbody2D>();   

    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, 
            new Vector2(PlayerHeight, PlayerRadius), CapsuleDirection2D.Horizontal, 0 , groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck) {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }

        if (_rigidbody2D.velocity.y < 0)
        {
            _rigidbody2D.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
    }
}
