using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour {
	[SerializeField]
	Material mat;
	[SerializeField]
		Renderer shade;


	// Use this for initialization
	void Start () {
	shade=GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		
		
	}

	void OnCollisionEnter( Collision cool)
	{
		if(cool.gameObject.CompareTag("Player"))
		{
			shade.sharedMaterial=mat;
		}
	}
}
