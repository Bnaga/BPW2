using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	public Rigidbody rigid;
	public float jumpForce;
	
	
	// Use this for initialization
	void Start ()
	{
		rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		rigid.velocity = new Vector3(Input.GetAxis("Horizontal")*moveSpeed,rigid.velocity.y,Input.GetAxis("Vertical")*moveSpeed);

		if (Input.GetButtonDown("Jump"))
		{
			rigid.velocity = new Vector3(rigid.velocity.x,jumpForce,rigid.velocity.z);
		}
	}
	
}
