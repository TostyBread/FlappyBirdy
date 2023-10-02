using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{

    public float JumpForce = 200f;

    private Rigidbody2D _rigidBody2D;
    
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // vector2 (0,0)
            // Vector2.up = (0, 1);
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            //Debug.Log("We should flap");

            //if (Input.GetButtonDown)
        }
    }
}
