using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

	public Rigidbody rbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
		{
			rbody.velocity = new Vector3(-20,0,0);
		}
		
	}
}
