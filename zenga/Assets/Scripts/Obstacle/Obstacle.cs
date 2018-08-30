using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
  
    

	 public void OnCollisionExit(Collision col)
	{
        if(col.gameObject.CompareTag("Ground") && col.gameObject.CompareTag("Player"))
		{
			gameObject.GetComponent<Rigidbody>().isKinematic = false;
		}

	}
}
