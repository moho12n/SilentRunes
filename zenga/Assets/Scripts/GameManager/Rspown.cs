using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rspown : MonoBehaviour {
	GameMaster gm;
	void Start()
	{
		gm=GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	}

	// Use this for initialization
void OnTriggerEnter2D(Collider2D cool)
{
			if(cool.tag=="Player")
			{
				gm.lastpos=transform.position;
			}
}

}
