using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	//public Rigidbody rigid;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveDirection;

	public float gravityScale;
	// Use this for initialization
	void Start ()
	{
		//rigid = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//rigid.velocity = new Vector3(Input.GetAxis("Horizontal")*moveSpeed,rigid.velocity.y,Input.GetAxis("Vertical")*moveSpeed);

		/*
		if (Input.GetButtonDown("Jump"))
		{
			rigid.velocity = new Vector3(rigid.velocity.x,jumpForce,rigid.velocity.z);
		}
		*/
		
		moveDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, moveDirection.y,Input.GetAxis("Vertical")*moveSpeed);

		if (controller.isGrounded)
		{
			//moveDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed,0f,Input.GetAxis("Vertical")*moveSpeed);
			
			if (Input.GetButtonDown("Jump"))
			{
				moveDirection.y = jumpForce;
			}
			moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale/50 * Time.deltaTime);
		}

		if (!controller.isGrounded)
		{
			moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
		}

		controller.Move(moveDirection * Time.deltaTime);
	}
	
}
