using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
        }
    }

}
