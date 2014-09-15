using UnityEngine;
using System.Collections;

public class knight : MonoBehaviour 
{
	//player
	public float speed; // declare the player move speed in Unity inspector
	public float maxSpeed;
	public float jumpForce; //set in the Unity inspector
	
	public bool isGrounded = false; //can see if set in the Unity inspector
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	
	void FixedUpdate()
	{	
		EndlessRun();
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		
		if (isGrounded && Input.GetMouseButtonDown(0))
		{
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}
	}
	
	void Update()
	{

	}
	
	void EndlessRun()
	{
		rigidbody2D.AddForce(new Vector2 (speed, 0));
	}
}
