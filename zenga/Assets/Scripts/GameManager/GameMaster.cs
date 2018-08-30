﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	// Use this for initialization
	private static GameMaster instance;
	public Vector2 lastpos;
	void Awake () 
	{
		if(instance==null)
		{
			instance=this;
			DontDestroyOnLoad(instance);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
