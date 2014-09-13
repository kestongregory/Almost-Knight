using UnityEngine;
using System.Collections;

public class knight : MonoBehaviour 
{
	//player
	public float speed; // declare the player move speed in Unity inspector
	public int jumpHeight; //set in the Unity inspector
	public bool isGrounded = false; //can see if set in the Unity inspector
	
	void Update()
	{
		EndlessRun();
		if (Input.GetKeyDown("space") && isGrounded)
		{
			Jump(); // call the function
		}
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		
	}
	
//	void OnTriggerEnter2D(Collider2D groundCollider)
//	{
//		Debug.Log("touched the ground!");
//	}
	
	void EndlessRun()
	{
		rigidbody2D.AddForce(new Vector2 (speed, 0));
	}
	
	void Jump()
	{
		if (!isGrounded)
		{
			return;
		}
		
		isGrounded = false;
	
		Debug.Log("space was pressed");
		rigidbody2D.AddForce(new Vector2(-5, jumpHeight));
	}
}
