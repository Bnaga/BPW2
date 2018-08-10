using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

	public float damage = 10f;
	public float range = 100f;

	public Camera cam;
	public Transform barrel;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
		
	}

	void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(barrel.position, cam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
		}
	}
}
