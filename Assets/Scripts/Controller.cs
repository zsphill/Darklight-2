using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]

public class Controller : MonoBehaviour {

public float playerSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		 
		  if(Input.GetKeyUp(KeyCode.W))
 Debug.Log("Input W");

		 
		//Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		//GetComponent<Rigidbody2D>().velocity=targetVelocity * maxSpeed;
		
		//float move = Input.GetAxis("Horizontal");
		 //GetComponent<Rigidbody2D>().velocity = new Vector2( move *maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	
	 if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
       {
           transform.Translate(0,playerSpeed * Time.deltaTime,0);
       }
       if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
       {
           transform.Translate(0,-playerSpeed * Time.deltaTime,0);
       }
       if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
       {
           transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
       }
       if(Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
       {
           transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
       }
	
	}
}
