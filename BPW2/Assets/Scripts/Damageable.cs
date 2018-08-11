using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{

	public float health = 10f;

	public void TakeDamage(float amount)
	{
		health -= amount;
		if (health <= 0f)
		{
			Die();
		}
	}

	public void Die()
	{
		Destroy(gameObject);
	}
}
