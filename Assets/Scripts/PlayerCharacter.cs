using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D myRigidbody;
    private float moveInput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetMovementInput();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void GetMovementInput()
    {
        moveInput = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        myRigidbody.velocity = new Vector2(moveInput * speed, myRigidbody.velocity.y);
        //transform.Translate(speed, 0, 0); DONT use transform.translate on physics engine object
    }
    private void Jump()
    {
        // TODO: make character jump
    }
        
}
