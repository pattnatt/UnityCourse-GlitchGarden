﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour 
{
	private LevelManager levelmanager;

	// Use this for initialization
	void Start () 
	{
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		levelmanager.LoadLevel("03 Lose Screen");
	}
}
