using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	public Text scoreText;
	private int points = 0;
	
	
	#region Singleton
	public static GameController instance;

	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		if(instance != null)
		{
			Debug.LogWarning("more than one instance of planning found!");
			return;
		}
		instance = this;
	}
	#endregion
	
	// Use this for initialization
	void Start () 
	{
		points = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = "Points: " + points;
	}

	public void AddPoints(int amount)
	{
		points += amount;
	}


	public int GetPoints()
	{
		return points;
	}
}
